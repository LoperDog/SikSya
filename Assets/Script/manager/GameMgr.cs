using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    public int PlayerCode;
    public ConfigClass.GameState ThisGameState;
    public ConfigClass.GameState BeforeGameStete;

    // 플레이어들의 네트워크 뷰 아이디를 가지고 있는다.
    public NetworkViewID [] PlayersID;
    // 킬데스 기록 앞이 순서 뒤가 기록 이다.
    public Dictionary<int,Dictionary<NetworkViewID, NetworkViewID>> GameKillDeathLog = new Dictionary<int, Dictionary<NetworkViewID, NetworkViewID>>();
    // 플레이어들의 이름, 팀번호, 캐릭터 번호, 킬, 데스
    public Dictionary<NetworkViewID, string> PlayersName = new Dictionary<NetworkViewID, string>();
    public Dictionary<NetworkViewID, int> PlayersTeam = new Dictionary<NetworkViewID, int>();
    public Dictionary<NetworkViewID, int> PlayersChar = new Dictionary<NetworkViewID, int>();
    public Dictionary<NetworkViewID, int> PlayersKill = new Dictionary<NetworkViewID, int>();
    public Dictionary<NetworkViewID, int> PlayersDeath = new Dictionary<NetworkViewID, int>();

    void Start ()
    {
        Game_Time_M = GameObject.Find("Time_M").GetComponent<Text>();
        Game_Time_S = GameObject.Find("Time_S").GetComponent<Text>();

        Tab = GameObject.Find("Tab").GetComponent<Transform>().gameObject;
        Tab.gameObject.SetActive(false);

        ThisGameState = ConfigClass.GameState.NoSession;
        BeforeGameStete = ConfigClass.GameState.NotStart;
        StartCoroutine("Game_Timer");
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
        for (Game_Time = 0.0f; Game_Time <= 3600; Game_Time += Time.deltaTime)
        {
            if (Game_Time % 60 < 10)
            {
                if (Game_Time < 600)
                {
                    Game_Time_M.text = "0" + (int)Mathf.Floor(Game_Time / 60) + ":" + ToString();
                }
                else
                {
                    Game_Time_M.text = (int)Mathf.Floor(Game_Time / 60) + ":" + ToString();
                }
                Game_Time_S.text = "0" + (int)Game_Time % 60 + ToString();
            }
            else
            {
                Game_Time_S.text = (int)Game_Time % 60 + ToString();
            }
            yield return null;
        }
    }
    // 플레이어 정보를 세팅하기 위해 기본적으로 아이디 들을 가지고 있는다. 그냥 캐싱.
    public void StartGetGamePlayerInfo()
    {
        GameObject [] Players = GameObject.FindGameObjectsWithTag("PLAYER");
        Debug.Log("Test Get GamePlayers : " + Players.Length);
        PlayersID = new NetworkViewID[Players.Length];
        for(int i = 0; i < Players.Length; i++)
        {
            PlayersID[i] = Players[i].GetComponent<NetworkView>().viewID;
        }
    }
    // 플레이어들이 각자 정보를 자신의 캐릭터에 저장하고 그 정보들을 네트워크 상에 다른 캐릭터에 전달한 후 각자의 게임메니저에 정보를 넣는다.
    public void AddPlayer(NetworkViewID ID, string Name, int TeamNumb, int CharNumb)
    {
        PlayersName[ID] = Name;
        PlayersChar[ID] = CharNumb;
        PlayersTeam[ID] = TeamNumb;
        PlayersKill[ID] = 0;
        PlayersDeath[ID] = 0;
    }
    // 누군가 누굴 죽였다.
    public void PKPD(NetworkViewID PK, NetworkViewID PD)
    {
        PlayersKill[PK] += 1;
        PlayersDeath[PD] += 1;
        Debug.Log(PlayersName[PK] + "가 " + PlayersName[PD] + "를 죽였다.");
        Debug.Log(PlayersName[PK] + "의 킬 : " + PlayersKill[PK]);
        Debug.Log(PlayersName[PD] + "의 데스 : " + PlayersDeath[PD]);
     }

    #region preProcess in GameState
        #endregion
        #region postProcess in GameState
        #endregion
    public void SetPlayerCode(int Code) { PlayerCode = Code; }
    public int GetPlayerCode() { return PlayerCode; }
    // 플레이어들의 팀정보를 받아온다.
    public int GetTeam(NetworkViewID ID) { return PlayersTeam[ID]; }
}
