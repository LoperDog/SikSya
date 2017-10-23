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
    public Text Red1_ID;
    public Text Red1_KD;
    public Text Red2_ID;
    public Text Red2_KD;
    public Text Red3_ID;
    public Text Red3_KD;
    public Text Blue1_ID;
    public Text Blue1_KD;
    public Text Blue2_ID;
    public Text Blue2_KD;
    public Text Blue3_ID;
    public Text Blue3_KD;

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
        Red1_ID = GameObject.Find("Red1_ID").GetComponent<Text>();
        Red1_KD = GameObject.Find("Red1_KD").GetComponent<Text>();
        Red2_ID = GameObject.Find("Red2_ID").GetComponent<Text>();
        Red2_KD = GameObject.Find("Red2_KD").GetComponent<Text>();
        Red3_ID = GameObject.Find("Red3_ID").GetComponent<Text>();
        Red3_KD = GameObject.Find("Red3_KD").GetComponent<Text>();
        Blue1_ID = GameObject.Find("Blue1_ID").GetComponent<Text>();
        Blue1_KD = GameObject.Find("Blue1_KD").GetComponent<Text>();
        Blue2_ID = GameObject.Find("Blue2_ID").GetComponent<Text>();
        Blue2_KD = GameObject.Find("Blue2_KD").GetComponent<Text>();
        Blue3_ID = GameObject.Find("Blue3_ID").GetComponent<Text>();
        Blue3_KD = GameObject.Find("Blue3_KD").GetComponent<Text>();
        
        ThisGameState = ConfigClass.GameState.NoSession;
        BeforeGameStete = ConfigClass.GameState.NotStart;
        StartCoroutine("Game_Timer");
        Tab.gameObject.SetActive(false);
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

            if (PlayersID != null)
            {
                for (int i = 0; i < PlayersID.Length; i++)
                {
                    NetworkViewID temp = PlayersID[0];
                    if (PlayersTeam[temp] == 0)//레드팀
                    {

                    }
                    else
                    {

                    }
                }
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
    }
    // 플레이어 정보를 세팅하기 위해 기본적으로 아이디 들을 가지고 있는다. 그냥 캐싱.
    public void StartGetGamePlayerInfo()
    {
        GameObject [] Players = GameObject.FindGameObjectsWithTag("PLAYER");
        Debug.Log("Test Get GamePlayers : " + Players.Length);
        PlayersID = new NetworkViewID[Players.Length];

    }
    // 플레이어들이 각자 정보를 자신의 캐릭터에 저장하고 그 정보들을 네트워크 상에 다른 캐릭터에 전달한 후 각자의 게임메니저에 정보를 넣는다.
    public void AddPlayer(NetworkViewID ID, string Name, int TeamNumb, int CharNumb)
    {
        PlayersID[TeamNumb] = ID;
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
    public int GetTeam(NetworkViewID ID) { return PlayersTeam[ID]%2; }
}
