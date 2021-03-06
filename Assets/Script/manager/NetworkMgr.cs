﻿using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine;
using ConstValueInfo;
using System;
using UnityEngine.UI;

public class NetworkMgr : MonoBehaviour
{
    private string MyIP = "";
    private string OtherIP = "";

    public Transform[] PlayerCreatePosition = new Transform[6];
    //접속 IP
    //private const string ip = "192.168.30.64";
    //접속 Port
    private const int port = 8080;
    //NAT 기능의 사용 여부
    private bool _useNat = false;
    // 플레이어 프리팹
    public GameObject[] player = new GameObject[6];
    public GameObject MyPlayer;
    public int MyPlayerNumb = 2;

    // 플레이어의 수를 확인한다.
    public int PlayerLimit = ConstValue.WrongValue;
    // 게임이 시작되었는지 확인한다.
    public bool IsStartGame = false;

    // 자신이 서버일때
    public bool ReadyToInitializeServer = false;    // 서버가 시작되었는지를 확인한다.
    
    // 시작할때 플레이어들의 번호에 맞추어 넣자.
    private void Start()
    {
        PlayerLimit = MyInfoClass.GetInstance().MyRoomInfo.GetPlayerLimit();
        PlayerCreatePosition = new Transform[6];
        PlayerCreatePosition[0] = GameObject.Find("Red_1").GetComponent<Transform>();//Red
        PlayerCreatePosition[2] = GameObject.Find("Red_2").GetComponent<Transform>();
        PlayerCreatePosition[4] = GameObject.Find("Red_3").GetComponent<Transform>();
        PlayerCreatePosition[5] = GameObject.Find("Blue_1").GetComponent<Transform>();//Blue
        PlayerCreatePosition[3] = GameObject.Find("Blue_2").GetComponent<Transform>();
        PlayerCreatePosition[1] = GameObject.Find("Blue_3").GetComponent<Transform>();

        // 싱글 플레이시에는 여기서 부터 스타트함수를 끝까지 주석한다.
        MyInfoClass.GetInstance().MyNetwork = this;
        /*
        if (Network.peerType == NetworkPeerType.Disconnected)
        {
            Debug.Log("세팅이 된다");
            //IPHostEntry host = Dns.GetHostByName(Dns.GetHostName());
            //foreach (IPAddress ip in host.AddressList)
            //{
            //    if (ip.AddressFamily == AddressFamily.InterNetwork)
            //    {
            //        MyIP = ip.ToString();
            //        break;
            //    }
            //}
        }*/
            MyIP = Network.player.ipAddress;
            // 연결 요청
            CSender tempSender = CSender.GetInstance();
            DataPacketInfo tempData = new DataPacketInfo((int)ProtocolInfo.ServerCommend, (int)ProtocolDetail.GetHostIP, 0, null);
            tempSender.Sendn(ref tempData);
    }
    private void Update()
    {
        // 게임이 시작 되지도 않았고 서버라면
        if (!IsStartGame)
        {
            // 서버는 시작되지 않았고 초기화준비는 되었다.
            if (ReadyToInitializeServer)
            {
                StartConnect();
            }
            if (Network.isServer)
            {
                int LoadedPlayerCnt = GameObject.FindGameObjectsWithTag("PLAYER").Length;
                Debug.Log("현재 연결된 플레이어 수 : " + LoadedPlayerCnt + " 리미트 플레이어수 : " + PlayerLimit);
                if (Network.connections.Length == (PlayerLimit-1) && MyPlayer != null && LoadedPlayerCnt == PlayerLimit )
                {
                    Debug.Log("호스트의 플레이어 수 : " + GameObject.FindGameObjectsWithTag("PLAYER").Length);
                    Debug.Log("Player Is Limit : " + Network.connections.Length + " 제한수 " + PlayerLimit);
                    IsStartGame = true;
                    GettingStarted();
                }
            }
        }
    }
    public void SetPlayer(GameObject Player)
    {
        MyPlayer = Player;
    }
    /*
    void OnGUI()
    {
         //싱글플레이시 여길 연다
        //if (Network.peerType == NetworkPeerType.Disconnected)
//{
        //}
            // 게임 서버 생성 버튼+
            if (GUI.Button(new Rect(20, 20, 200, 50), "두부 캐릭터로 세팅"))
            {
                MyInfoClass.GetInstance().MyCharNumb = 0;
                MyInfoClass.GetInstance().MyGameNumb = 0;
            }
            // 게임에 접속하는 버튼
            if (GUI.Button(new Rect(20, 100, 200, 50), "만두 캐릭터 세팅"))
            {
                MyInfoClass.GetInstance().MyCharNumb = 1;
                MyInfoClass.GetInstance().MyGameNumb = 1;
            }
            if (GUI.Button(new Rect(20, 180, 200, 50), "호스트"))
            {
                Network.InitializeServer(20, port, _useNat);
                //GettingStarted();
            }
            if (GUI.Button(new Rect(20, 260, 200, 50), "로컬 접속"))
            {
                Network.Connect("127.0.0.1", port);
                //GettingStarted();
            }
    }*/
    // 호스트 아이피를 찾는다.
    public void SetHostIP(string hostip)
    {
        OtherIP = hostip;
        Debug.Log("접속해야 하는 호스트 번호" + OtherIP);
        ReadyToInitializeServer = true;
    }
    private void StartConnect()
    {
        // 네트워크를 끊고 시작한다.
        Debug.Log("연결된 네트워크를 끊고 연결을 시작한다.");
        NetworkConnectionError errorCode = NetworkConnectionError.ConnectionFailed;
        // 내가 호스트가 아닐경우
        if (OtherIP != MyIP)
        {
            while (errorCode != NetworkConnectionError.NoError)
            {
                Debug.Log("게스트 접속중");
                try
                {
                    errorCode = Network.Connect(OtherIP, port);
                    Debug.Log(errorCode);
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                }
            }
            Debug.Log("게스트 접속 성공");
        }
        // 내가 호스트인경우
        else
        {
            while (errorCode != NetworkConnectionError.NoError)
            {
                try
                {
                    errorCode = Network.InitializeServer(32, port, _useNat);

                    if (errorCode == NetworkConnectionError.AlreadyConnectedToAnotherServer ||
                        errorCode == NetworkConnectionError.AlreadyConnectedToServer)
                    {
                        Network.Disconnect();
                    }
                    else if (errorCode == NetworkConnectionError.ConnectionBanned)
                    {
                        Debug.Log("연결을 차단당했다.");
                    }
                    else
                    {
                        Debug.Log("뭔가를 더 할수가 없다.");
                    }
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                }
                // 만약 이미 연결된 서버가 있다면
                //if (errorCode == NetworkConnectionError.AlreadyConnectedToAnotherServer ||
                //    errorCode == NetworkConnectionError.AlreadyConnectedToServer)
                //{
                //    // 연결을 끊고 자기자신을 불러온다.
                //    Network.Disconnect();
                //    this.StartConnect();
                //}
                //ReadyToInitializeServer = false;
            }
        }
        Debug.Log("연결 결과 에러 로그 : " + errorCode);
        ReadyToInitializeServer = false;
    }


    // 게임 서버로 구동시키고 서버 초기화가 정상적으로 완료됐을 때 자동 호출됨
    void OnServerInitialized()
    {
        CreatePlayer();
    }

    // 클라이언트로 게임 서버에 접속했을 때 자동 호출됨.
    void OnConnectedToServer()
    {
        CreatePlayer();
    }

    // 플레이어를 생성하는 함수
    void CreatePlayer()
    {
        Transform pos = PlayerCreatePosition[MyInfoClass.GetInstance().MyGameNumb];
        int CheckTeam = (MyInfoClass.GetInstance().MyGameNumb % 2) == 0 ? 0 : 2;
        if(CheckTeam == 0)//레드
        {
            Network.Instantiate(player[MyInfoClass.GetInstance().MyCharNumb + CheckTeam]
            , pos.position, pos.rotation, 0);
        }
        else//블루
        {
            Network.Instantiate(player[MyInfoClass.GetInstance().MyCharNumb + 3]
            , pos.position, pos.rotation, 0);
        }
    }

    // 모든 플레이어가 로드 되었다.
    public void GettingStarted()
    {
        MyPlayer.GetComponent<Transform>().GetComponent<CharacterMgr>().SetStarted();
    }
    // 접속이 종료된 플레이어의 네트워크 객체를 모두 소멸 처리
    void OnPlayerDisconnected(NetworkPlayer netPlayer)
    {
        // 네트워크 플레이어의 모든 Buffered RPC를 소멸 처리
        Network.RemoveRPCs(netPlayer);
        // 네트워크 플레이어의 모든 네트워크 객체를 소멸 처리(게임 서버가 구동되고 있어야 이용 가능)
        Network.DestroyPlayerObjects(netPlayer);
    }
}