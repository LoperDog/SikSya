using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConstValueInfo;
using UnityEngine.UI;

public class Channel : MonoBehaviour {

    //GameObject mMatchingPanel;
    CSender mSender;
    
    [SerializeField]
    GameObject[] ChannelChannel = new GameObject[ConstValue.ChannelSceneCharacterKind];
    GameObject mGameLogoObj;
    // Use this for initialization
    void Awake () {
        //mMatchingPanel = GameObject.FindGameObjectWithTag("MatchingPanel");
        ChannelCharacterInit();
        //ChannelChannel[ChannelSelectRandomCharacter()].SetActive(true); // 랜덤 캐릭터 출력
        mSender = CSender.GetInstance();
        GameObject.FindGameObjectWithTag("TagChannelMyNameText").GetComponent<Text>().text = MyInfoClass.GetInstance().MyName;
        mGameLogoObj = GameObject.FindGameObjectWithTag("TagChannelMaster").GetComponentInChildren<Transform>().FindChild("GameLogo").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        State curState = CheckState.GetCurState();
        if (State.ClientMatching == curState)
        {
            if (Input.GetKeyUp(KeyCode.Escape) || Input.GetKeyUp("escape"))
            {
                CancleMatching();
            }
        }
    }

    IEnumerator GameLogoFade()
    {
        mGameLogoObj.GetComponent<Image>().color = new Color(255.0f, 255.0f, 255.0f, 0.0f);
        float alpha = 0.0f;
        float delayTime = 0.0f;
        while (delayTime < 9.0f)
        {
            delayTime += 1.0f;
            yield return new WaitForSeconds(1.0f);
        }
        while(alpha < 255.0f)
        {
            mGameLogoObj.GetComponent<Image>().color = new Color(255.0f, 255.0f, 255.0f, alpha);
            alpha += 5.0f;
            yield return new WaitForSeconds(0.2f);
        }
       
        yield return null;
    }

    void ChannelCharacterInit()
    {
        foreach(GameObject g in ChannelChannel)
        {
            g.SetActive(false);
        }
    }

    int ChannelSelectRandomCharacter()
    {
        return Random.Range(0, ConstValue.ChannelSceneCharacterKind);
    }

    public void RequestMatching()
    {
        State curState = CheckState.GetCurState();
        if (State.ClientChannelMenu == curState)
        {
            CheckState.ChangeState(State.ClientRequestMatching);
            DataPacketInfo dataEnterRoom = new DataPacketInfo((int)ProtocolInfo.ServerCommend, (int)ProtocolDetail.EnterRoom, (int)ProtocolChannelMenuTag.MatchingStart, null);
            mSender.Sendn(ref dataEnterRoom);
            OutSoundPlayer.PlayClickSound(SoundClip.Click);
        }
    }

    public void CancleMatching()
    {
        State curState = CheckState.GetCurState();
        if (State.ClientRequestCancleMactching != curState)
        {
            CheckState.ChangeState(State.ClientRequestCancleMactching);
            DataPacketInfo dataOutRoom = new DataPacketInfo((int)ProtocolInfo.ServerCommend, (int)ProtocolDetail.OutRoom, (int)ProtocolChannelMenuTag.MatchingCancel, null);
            mSender.Sendn(ref dataOutRoom);
            OutSoundPlayer.PlayClickSound(SoundClip.Click);
        }
    }

    public void MakeRoomButton()
    {
        State curState = CheckState.GetCurState();
        if(State.ClientChannelMenu == curState)
        {
            CheckState.ChangeState(State.ClientMakeRoom);
            OutSoundPlayer.PlayClickSound(SoundClip.Click);
        }
    }

    public void EnterRoomButton()
    {
        State curState = CheckState.GetCurState();
        if (State.ClientChannelMenu == curState)
        {
            CheckState.ChangeState(State.ClientEnterSpecialRoom);
            OutSoundPlayer.PlayClickSound(SoundClip.Click);
        }
    }

    public void ExitButton()
    {
        Application.Quit();
        OutSoundPlayer.PlayClickSound(SoundClip.Click);
    }

}
