using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    public static float Game_Time;
    public Text Game_Time_M;
    public Text Game_Time_S;

    public int PlayerCode;
    public ConfigClass.GameState ThisGameState;
    public ConfigClass.GameState BeforeGameStete;

	void Start ()
    {
        Game_Time_M = GameObject.Find("Time_M").GetComponent<Text>();
        Game_Time_S = GameObject.Find("Time_S").GetComponent<Text>();

        ThisGameState = ConfigClass.GameState.NoSession;
        BeforeGameStete = ConfigClass.GameState.NotStart;
        StartCoroutine("Game_Timer");
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(this.ThisGameState != this.BeforeGameStete)
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

    #region preProcess in GameState
        #endregion
        #region postProcess in GameState
        #endregion
    public void SetPlayerCode(int Code) { PlayerCode = Code; }
    public int GetPlayerCode() { return PlayerCode; }
}
