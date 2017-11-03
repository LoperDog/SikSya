using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConstValueInfo;
using UnityEngine.UI;

public class ChangeCharacter : MonoBehaviour {

    CSender mSender;
    Chatting ChatScript;
    [SerializeField]
    Sprite[] mSelectCharacterInfoSprite = new Sprite[3];
    Image mSelectCharacterInfo;
    [SerializeField]
    GameObject[] mDubu = new GameObject[2];
    [SerializeField]
    GameObject[] mMandu = new GameObject[2];

    // Use this for initialization
    void Awake () {
        mSender = CSender.GetInstance();
        ChatScript = GameObject.FindGameObjectWithTag("ChatPanel").GetComponent<Chatting>();
        mSelectCharacterInfo = GameObject.FindGameObjectWithTag("TagInfoSelectCharacter").GetComponent<Image>();
        StartCoroutine("RoomInSelectMotion");
    }

    IEnumerator RoomInSelectMotion()
    {
        while(true)
        {
            Debug.Log("RoomInSelectMotion 코루틴 호출 됨.");
            if (MyInfoClass.IsMyInfoInit())
            {
                SelectCharacterMotion(ProtocolCharacterImageNameIndex.Tofu);
                break;
            }
            yield return new WaitForSeconds(0.1f);
        }
        yield return null;
    }

    public void SelectTofu()
    {
        SelectCharacter(ProtocolCharacterImageNameIndex.Tofu);
    }

    public void SelectMandu()
    {
//        Debug.Log("만두선택");
        SelectCharacter(ProtocolCharacterImageNameIndex.Mandu);
    }

    public void SelectTangsuyuk()
    {
        SelectCharacter(ProtocolCharacterImageNameIndex.Tangsuyuk);
    }

    public void ReadyButton()
    {
        int protocolDetail;
        if(CheckState.GetCurState() == State.ClientNotReady || CheckState.GetCurState() == State.ClientNotAllReady)
        {
            protocolDetail = (int)ProtocolDetail.SetReadyGame;
            CheckState.ChangeState(State.ClientRequestGaemReady); // 요청 상태로 변경
            //CheckState.ChangeState(State.ClientReady);
        }
        else
        {
            protocolDetail = (int)ProtocolDetail.NotReadyGame;
            CheckState.ChangeState(State.ClientRequestGaemNotReady); // 요청 상태로 변경
            //CheckState.ChangeState(State.ClientNotReady);
        }
        OutSoundPlayer.PlayClickSound(SoundClip.Click);
        DataPacketInfo dataInfo = new DataPacketInfo((int)ProtocolInfo.ServerCommend, protocolDetail, 0, null);
        mSender.Sendn(ref dataInfo);
   //     Debug.Log("ReadyButton누름");
    }

    void SelectCharacterInit()
    {
        foreach (GameObject g in mDubu)
        {
            g.SetActive(false);
            g.transform.position = new Vector3();
        }
        foreach (GameObject g in mMandu)
        {
            g.SetActive(false);
            g.transform.position = new Vector3();
        }
    }

    void SelectCharacterMotion(ProtocolCharacterImageNameIndex characterIndex)
    {
        SelectCharacterInit();
        int team = (MyInfoClass.GetInstance().MyGameNumb % 2); // red : 짝수 , blue : 홀수
        switch (characterIndex)
        {
            case ProtocolCharacterImageNameIndex.Tofu:
                mDubu[team].SetActive(true);
                break;
            case ProtocolCharacterImageNameIndex.Mandu:
                mMandu[team].SetActive(true);
                break;
            case ProtocolCharacterImageNameIndex.Tangsuyuk:
                break;
            default:
                break;
        }
    }

    void SelectCharacter(ProtocolCharacterImageNameIndex characterIndex)
    {
        Debug.Log("캐릭터 선택 내 상태 = " + CheckState.GetCurState());
        State curState = CheckState.GetCurState();
        if ((State.ClientNotAllReady == curState || curState == State.ClientNotReady) && State.ClientRequestCharacterChange != curState)
        {
            DataPacketInfo dataInfo = new DataPacketInfo((int)ProtocolInfo.ServerCommend, (int)ProtocolDetail.ChangeCharacter, (int)characterIndex, null);
            mSender.Sendn(ref dataInfo);
            CheckState.ChangeState(State.ClientRequestCharacterChange);
            mSelectCharacterInfo.sprite = mSelectCharacterInfoSprite[(int)characterIndex];
            SelectCharacterMotion(characterIndex);
            OutSoundPlayer.PlayClickSound(SoundClip.Click);
        }
    }

    public void SelectLockCharacter()
    {
        if (null == ChatScript)
        {
            Debug.Log("ChatScript가 null임");
            return;
        }
        Debug.Log("SelectLockCharacter");
        ChatScript.AddDialogue(ConstValue.NoticeReadyNoChangeCharacter);
    }

}
