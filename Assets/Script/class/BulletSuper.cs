using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BulletSuper : MonoBehaviour
{
    // 생존 시간
    public float m_CurrentLifeTime = 0.0f;
    public float m_MaxLifeTime = 5.0f;

    // 총알을 발사하기 위한 준비
    protected float BulletSpeed;
    protected Transform Bullet_tr;
    public Transform Player_tr;
    protected int PlayerCode;

    protected bool IsLift;

    public Transform Effect;

    public GameMgr Mgr;
    static ConfigClass config;

    public virtual void FireBullet(Vector3 position, Quaternion rotation, float FireSpeed, int code)
    {
        SetBullet(position, rotation);

        Bullet_tr = transform;

        BulletSpeed = FireSpeed;
        m_CurrentLifeTime = 0.0f;
        PlayerCode = code;
        IsLift = true;
    }
    // 충돌처리
    protected virtual void OnTriggerEnter(Collider other)
    {
        // 각도 계산 필요.
        Vector3 qu = transform.position - other.transform.position;

        Transform effect = Instantiate(Effect, transform.position, Quaternion.LookRotation(qu));

        IsLift = false;
        if (other.transform.tag == "PLAYER")
        {
            if(config == null)
            {
                config = new ConfigClass();
            }
            Player_tr.GetComponent<CharacterMgr>().ShotPlayer(other.transform.GetComponent<NetworkView>(),config.StatusConfigs["Dubu"]["Attack"]);
            Debug.Log("맞은 친구" + other.transform.name + " 뷰 아이디 : " + other.transform.GetComponent<NetworkView>().viewID);
        }
        SetBulletEnalbed();
    }
    /*
    // 현제는 두개다 만들어 둔다.
    protected virtual void OnCollisionEnter(Collision col)
    {
        // 각도 계산 필요.
        Vector3 qu = transform.position - col.transform.position;

        Transform effect = Instantiate(Effect, transform.position, Quaternion.LookRotation(qu));

        IsLift = false;
        if (col.transform.tag == "PLAYER")
        {
            if(config == null)
            {
                config = new ConfigClass();
            }
            Player_tr.GetComponent<CharacterMgr>().ShotPlayer(col.transform.GetComponent<NetworkView>(),config.StatusConfigs["Dubu"]["Attack"]);
            Debug.Log("맞은 친구" + col.transform.name + " 뷰 아이디 : " + col.transform.GetComponent<NetworkView>().viewID);
        }
        SetBulletEnalbed();
    }*/

    // 생성 당시에 플레이어 코드를 
    protected void SetCode(int Code) { PlayerCode = Code; }
    protected void SetGameMgr(GameMgr gamemgr) { Mgr = gamemgr; }

    protected void SetBullet(Vector3 position, Quaternion rotation)
    {
        transform.position = position;
        transform.rotation = rotation;
        //Mgr = GameObject.FindGameObjectWithTag("GAMEMGR").GetComponent<GameMgr>() ;
    }
    // 총알을 초기화 한다.
    protected void SetBulletEnalbed()
    {
        // 시간초기화 및 자신의 비활성화
        m_CurrentLifeTime = 0.0f;
        gameObject.SetActive(false);
    }

    void Update()
    {
        if (IsLift)
        {
            Debug.DrawLine(transform.position, transform.position + transform.forward * 10f, Color.magenta);
            // 총알이 살아 있는 동안 할행동
            m_CurrentLifeTime += Time.deltaTime;
            if (m_CurrentLifeTime > m_MaxLifeTime)
            {
                SetBulletEnalbed();
            }
        }
    }
    void FixedUpdate()
    {
        if (IsLift)
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * 50f);
        }
    }
}
