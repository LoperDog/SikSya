using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConstValueInfo;
using UnityEngine.UI;

public class Channel : MonoBehaviour {

    //GameObject mMatchingPanel;
    CSender mSender;
    // Use this for initialization
    void Awake () {
        //mMatchingPanel = GameObject.FindGameObjectWithTag("MatchingPanel");
        mSender = CSender.GetInstance();
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
