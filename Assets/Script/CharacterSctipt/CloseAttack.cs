using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAttack : MonoBehaviour {
    protected Transform MyPlayer;
    protected CharacterMgr MyMgr;
    // 임시로 살아있을때 닿은 플레이어들을 저장한다. 리셋후 죽음
    protected NetworkView[] Target_NetworkView = new NetworkView[6];
    protected float Damege;

    public virtual Transform Player
    {
        get
        {
            return MyPlayer;
        }
        set
        {
            MyPlayer = value;
            MyMgr = value.GetComponent<CharacterMgr>();
        }
    }
    public virtual float Dam
    {
        get
        {
            return Damege;
        }
        set
        {
            Damege = value;
        }
    }
    //무언가에 닿았다
    public virtual void OnTriggerEnter(Collider other)
    {
        Transform tempTransForm = other.GetComponent<Transform>();
        if (tempTransForm.tag == "PLAYER")
        {
            // 만약 자기 자신이라면
            if (tempTransForm == Player)
            {
                Debug.Log("플레이어에 닿았음.");
                return;
            }
            //자신이 아니라면....
            int tempIndex = -1;
            for (int i = 0; i < 6; i++)
            {
                tempIndex = i;
                // 만약 이미 있는 것이라면
                if (Target_NetworkView[i] == tempTransForm.GetComponent<NetworkView>())
                {
                    return;
                }
            }
            Target_NetworkView[tempIndex] = tempTransForm.GetComponent<NetworkView>();

            AttackPlayer(Target_NetworkView[tempIndex]);
        }
    }

    // 플레이어를 공격했다!.
    public virtual void AttackPlayer(NetworkView Tg)
    {
        MyMgr.ShotPlayer(Tg, Damege);
    }

    // 공격을 멈추고 돌아간다.
    public virtual void ReSetAttack()
    {
        Debug.Log("일단 근접공격이 끝났다.");
        Target_NetworkView = new NetworkView[6];
        gameObject.SetActive(false);
    }
}