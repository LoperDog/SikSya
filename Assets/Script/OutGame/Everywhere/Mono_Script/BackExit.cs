using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConstValueInfo;

public class BackExit : MonoBehaviour {

    CSender mSender;
    

    void Awake()
    {
        mSender = CSender.GetInstance();
    }

    public void ExitButton()
    {
//        Debug.Log("뒤로가기 버튼 클릭 / 상태에 따른 씬변경 요청");
        State curState = CheckState.GetCurState();
        DataPacketInfo dataInfo = new DataPacketInfo();
        Debug.Log("ExitButton curState = " + curState);
        if (curState != State.ClientReady && curState != State.ClientRequestBackExit)
        {
            switch(curState)
            {
                case State.ClientNotAllReady:
                case State.ClientNotReady:
                    dataInfo = new DataPacketInfo((int)ProtocolInfo.ServerCommend, (int)ProtocolDetail.OutRoom, (int)State.ClientRequestBackExit, null);
                    OutSoundPlayer.PlayClickSound(SoundClip.Click);
                    //Debug.Log("나가기 요청 패킷 만듬");
                    break;
                default:
                    break;
            }
            mSender.Sendn(ref dataInfo);
            CheckState.ChangeState(State.ClientRequestBackExit);
        }
    }

    public void ExitLockButton()
    {
        if (CheckState.GetCurScene() == ProtocolSceneName.RoomScene)
        {
            Chatting ChatScript = GameObject.FindGameObjectWithTag("ChatPanel").GetComponent<Chatting>();
            return;
        }
    }

}
