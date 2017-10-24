﻿using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine;
using ConstValueInfo;
using System;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    //시간
    public static float Game_Time;
    public Text Game_Time_M;
    public Text Game_Time_S;

    //탭키
    public GameObject Tab;
    public bool Tab_Open= false;

    public Text [] Team_ID;
    public Text [] Team_KD;

    public Image Game_Result;

    public ConfigClass.GameState ThisGameState;
    public ConfigClass.GameState BeforeGameStete;

    // 플레이어들의 네트워크 뷰 아이디를 가지고 있는다.
    public NetworkViewID [] PlayersID;
    // 킬데스 기록 앞이 순서 뒤가 기록 이다.
    public Dictionary<int,Dictionary<NetworkViewID, NetworkViewID>> GameKillDeathLog = new Dictionary<int, Dictionary<NetworkViewID, NetworkViewID>>();
    // 플레이어들의 이름, 팀번호, 캐릭터 번호, 킬, 데스
    public Dictionary<NetworkViewID, string> PlayersName;
    public Dictionary<NetworkViewID, int> PlayersTeam;
    public Dictionary<NetworkViewID, int> PlayersChar;
    public Dictionary<NetworkViewID, int> PlayersKill;
    public Dictionary<NetworkViewID, int> PlayersDeath;

    // UI에 세팅된 플레이어의 수를 체크한다.
    public int SettingUIPlayer;
    void Start ()
    {
        SettingUIPlayer = 0;
        PlayersName = new Dictionary<NetworkViewID, string>();
        PlayersTeam = new Dictionary<NetworkViewID, int>();
        PlayersChar = new Dictionary<NetworkViewID, int>();
        PlayersKill = new Dictionary<NetworkViewID, int>();
        PlayersDeath = new Dictionary<NetworkViewID, int>();
        
        Game_Time_M = GameObject.Find("Time_M").GetComponent<Text>();
        Game_Time_S = GameObject.Find("Time_S").GetComponent<Text>();

        Tab = GameObject.Find("Tab").GetComponent<Transform>().gameObject;
        Team_ID = new Text[6];
        Team_KD = new Text[6];
        Team_ID[0] = GameObject.Find("Red1_ID").GetComponent<Text>();//아이디
        Team_ID[2] = GameObject.Find("Red2_ID").GetComponent<Text>();
        Team_ID[4] = GameObject.Find("Red3_ID").GetComponent<Text>();
        Team_ID[1] = GameObject.Find("Blue1_ID").GetComponent<Text>();
        Team_ID[3] = GameObject.Find("Blue2_ID").GetComponent<Text>();
        Team_ID[5] = GameObject.Find("Blue3_ID").GetComponent<Text>();

        Team_KD[0] = GameObject.Find("Red1_KD").GetComponent<Text>();//킬뎃
        Team_KD[2] = GameObject.Find("Red2_KD").GetComponent<Text>();
        Team_KD[4] = GameObject.Find("Red3_KD").GetComponent<Text>();
        Team_KD[1] = GameObject.Find("Blue1_KD").GetComponent<Text>();
        Team_KD[3] = GameObject.Find("Blue2_KD").GetComponent<Text>();
        Team_KD[5] = GameObject.Find("Blue3_KD").GetComponent<Text>();
        
        ThisGameState = ConfigClass.GameState.NoSession;
        BeforeGameStete = ConfigClass.GameState.NotStart;
        StartCoroutine("Game_Timer");
        Tab.gameObject.SetActive(false);
        //결과
        Game_Result = GameObject.Find("Game_Result").GetComponent<Image>();
        Game_Result.enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Tab_State();
        if (this.ThisGameState != this.BeforeGameStete)
        {

            switch (this.BeforeGameStete)
            {
                case ConfigClass.GameState.NotStart:
                    break;

                case ConfigClass.GameState.NoSession:
                    break;

                case ConfigClass.GameState.InRoom:
                    break;

                case ConfigClass.GameState.InGame:
                    break;
                /*case ConfigClass.GameState.Matching:
                    break;*/
            }
        }
        switch (this.ThisGameState)
        {
            case ConfigClass.GameState.NoSession:
                break;

            case ConfigClass.GameState.InRoom:
                break;

            case ConfigClass.GameState.InGame:
                break;

            /*case ConfigClass.GameState.Matching:
                break;*/
        }
    }
    void Tab_State()
    {
        if (!Tab_Open && Input.GetKey(KeyCode.Tab))
        {
            Tab.gameObject.SetActive(true);
            Tab_Open = true;
        }
        else if (Tab_Open && Input.GetKeyUp(KeyCode.Tab))
        {
            Tab.gameObject.SetActive(false);
            Tab_Open = false;
        }
    }
    IEnumerator Game_Timer()
    {
        for (Game_Time = 300.0f; Game_Time >= 0.0f; Game_Time -= Time.deltaTime)
        {
            Game_Time_M.text = "0" + (int)(Game_Time / 60) + " :";
            if ((int)(Game_Time % 60) < 10)
            {
                Game_Time_S.text = "0" + (int)(Game_Time % 60) + ToString();
            }
            else
            {
                Game_Time_S.text = (int)(Game_Time % 60) + ToString();
            }
            yield return null;
        }
        // 끝나면 실행되겠지?
        GameObject.FindGameObjectWithTag("PLAYER").GetComponent<CharacterMgr>().SetGameEnd();
    }
    public void MgrGameEnd()
    {
        StartCoroutine(EndGameTurm());
    }
    public IEnumerator EndGameTurm()
    {
        // UI띄우기
        int MyTeam = MyInfoClass.GetInstance().MyGameNumb % 2;
        int redKill = 0 ;
        int blueKill = 0 ;
        for(int i = 0; i < PlayersID.Length; i++)
        {
            if (GetTeam(PlayersID[i]) == 0)
                redKill += PlayersKill[PlayersID[i]];
            else
                blueKill += PlayersKill[PlayersID[i]];
        }

        if(redKill > blueKill && MyTeam ==0)
        {
            // 레드팀이 이겼다.
            Game_Result = GameObject.Find("Win").GetComponent<Image>();
            Game_Result.enabled = true;
            Debug.Log("이겼어");
        }
        else
        {
            // 블루팀이 이겼다
            Game_Result = GameObject.Find("Lose").GetComponent<Image>();
            Game_Result.enabled = true;
            Debug.Log("졌어");
        }
        yield return new WaitForSeconds(5.0f);
        Game_Result.enabled = false;
        if (Network.isServer)
            GameOver();
    }
    public void GameOver()
    {
        CSender tempSender = CSender.GetInstance();
        DataPacketInfo gameOverPacket = new DataPacketInfo((int)ProtocolInfo.ServerCommend, (int)ProtocolDetail.OutMainGameScene, (int)ProtocolTagNull.Null, null);
        Screen.lockCursor = false;
        tempSender.Sendn(ref gameOverPacket);
    }
    // 플레이어 정보를 세팅하기 위해 기본적으로 아이디 들을 가지고 있는다. 그냥 캐싱.
    public void StartGetGamePlayerInfo()
    {
        GameObject [] Players = GameObject.FindGameObjectsWithTag("PLAYER");
        PlayersID = new NetworkViewID[Players.Length];
    }
    // 플레이어들이 각자 정보를 자신의 캐릭터에 저장하고 그 정보들을 네트워크 상에 다른 캐릭터에 전달한 후 각자의 게임메니저에 정보를 넣는다.
    public void AddPlayer(NetworkViewID ID, string Name, int TeamNumb, int CharNumb)
    {
        if (PlayersID == null)
        {
            StartGetGamePlayerInfo();
        }
        PlayersID[TeamNumb] = ID;
        PlayersName[PlayersID[TeamNumb]] = Name;
        PlayersChar[PlayersID[TeamNumb]] = CharNumb;
        PlayersTeam[PlayersID[TeamNumb]] = TeamNumb;
        PlayersKill[PlayersID[TeamNumb]] = 0;
        PlayersDeath[PlayersID[TeamNumb]] = 0;

        SettingUIPlayer++;
        Debug.Log("ID! : " + ID);
        Debug.Log("inID! : " + ID);
        Debug.Log("Name! : " + Name);
        Debug.Log("Inname! : " + PlayersName[PlayersID[TeamNumb]]);
        if (SettingUIPlayer == PlayersID.Length)
        {
            int PlayersLength = PlayersID.Length;
            Debug.Log("플레이어의 수는 : " + PlayersLength);
            for (int i = 0; i < PlayersLength; i++)
            {
                Debug.Log("플레이어의 정보를 세팅중이다. : " + i);
                Debug.Log("뭔데 : " + PlayersID[i]);
                Debug.Log("뭔데wekgmwe : " + PlayersName[PlayersID[0]]);
                Team_ID[i].text = PlayersName[PlayersID[i]];
                Team_KD[PlayersTeam[PlayersID[i]]].text = "0/0";
                Debug.Log("정보 세팅이 완료 되었다.");
            }
        }
    }
    // 누군가 누굴 죽였다.
    public void PKPD(NetworkViewID PK, NetworkViewID PD)
    {
        PlayersKill[PK] += 1;
        PlayersDeath[PD] += 1;
        Team_KD[PlayersTeam[PK]].text = PlayersKill[PK].ToString() + "/" + PlayersDeath[PK].ToString();
        Team_KD[PlayersTeam[PD]].text = PlayersKill[PD].ToString() + "/" + PlayersDeath[PD].ToString();
    }

    #region preProcess in GameState
        #endregion
        #region postProcess in GameState
        #endregion
    // 플레이어들의 팀정보를 받아온다.
    public int GetTeam(NetworkViewID ID) { return PlayersTeam[ID]%2; }
}
