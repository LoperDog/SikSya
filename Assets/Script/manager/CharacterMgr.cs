﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMgr : MonoBehaviour
{
    public Camera mainCamera;

    [SerializeField]
    public ConfigClass config;
    [SerializeField]
    public GameMgr MyMgr;

    public Transform Player_tr;
    private Rigidbody Player_rb;
    private Transform Camera_tr;

    public NetworkView _networkView;
    private Vector3 Char_Pos;
    private Quaternion Char_Rot;

    string CharType = "";
    [SerializeField]
    Dictionary<string, GameObject> TempBulletPool;
    [SerializeField]
    List<GameObject> LoadChar;
    [SerializeField]
    public List<GameObject> LoadBullet;

    //공용UI
    public Text Bullet_count;
    public Image HP_image;
    public Image Cartridge_image;
    public Image Right_Black;
    public Image Special_Black;
    public Image Right_Gauge;
    public Image Special_Gauge;
    public Text Right_Cool;
    public Text Special_Cool;

    //캐릭터별 UI
    public Image Dubu_Right;
    public Image Dubu_Special;

    public Image Mandu_Right;
    public Image Mandu_Special;

    public Image Tangsu_Right;
    public Image Tangsu_Special;

    // 네트워크에서 약간의 딜레이가 들어간 움직임 목표점.
    private Vector3 LerpPos;
    private Vector3 SyncVel;

    private Quaternion LerpRot;
    private float LerpSpeed = 3.0f;
    private float LerpDelay = 0.0f;

    //private float LerpPosStartTime = 0.0f;
    private float LerpRotStartTime = 0.0f;
    private float PosSyncStartTime = 0;
    private float PosSyncDelayTime = 0;
    private float LastSyncTime = 0.0f;

    // 캐릭터 리스트가 필요하다.
    public SkinnedMeshRenderer[] Meshs;
    public enum Character_Type
    {
        Dubu,
        Mandu,
        Tangsu
    };
    public string MyName;
    public int MyTeam;
    public int MyCharNumb;

    // 마지막으로 날 공격한 놈의 네트워크 뷰 아이디
    public NetworkViewID LastAttacker;
    #region 캐릭터 정보
    [SerializeField]
    public float Char_Max_HP;
    [SerializeField]
    public float Char_Current_HP;

    [SerializeField]
    private int Player_ID;
    [SerializeField]
    private bool IsDead = false;

    [SerializeField]
    public int PlayerCode = 0;
    // 초기화 무적
    public bool OverPower = false;
    public float RAY_MaxDist = 500;

    private bool IsCharacterLoaded = false; // 캐릭터 세팅이 끝났는가?
    private bool IsGameLoaded = false;      // 게임로딩이 끝났는가?
    private bool IsInGameSetting = false;   // 요청이 떨어졌는가?

    // 아이템
    public bool AttackBuff;
    public int AttackBuffIOverLapping;
    public Transform AttackBuffEffect;
    public bool DepanceBuff;
    public int DepanceBuffOverLapping;
    public Transform DepanceBuffEffect;
    public bool SmallBuff;
    public int SmallBuffOverLapping;
    public bool BigBuff;
    public int BigBuffOverLapping;

    #endregion
    #region UI표현에 필요한 변수
    //강공격
    public float StrongAttackCoolTime = 0.0f;
    //특수기
    public float SpecialAttackCoolTime = 0.0f;
    #endregion
    #region 캐릭터 내부 스크립트 혹은 클래스
    // 필요한 기능등 붙이기
    [SerializeField]
    private Character_Type Character_ID;

    [SerializeField]
    private AnimationSuper thisAnim;

    // 이 캐릭터가 실행할 스크립트\
    [SerializeField]
    private CharacterSuper thisCharacter;
    public float Current_Bullet;
    public float Max_Bullet;
    #endregion

    #region 캐릭터키값
    // 이동키
    private float Key_H = 0.0f;             //키동기 필요
    public float keyh
    {
        get { return Key_H; }
        set { Key_H = value; }
    }
    private float Key_V = 0.0f;
    public float keyv
    {
        get { return Key_V; }
        set { Key_V = value; }
    }
    // 공격키
    private bool Click_Left = false;        // 개별동기
    private bool Click_Right = false;
    // 달리기 키
    private bool Key_Shift = false;         // 키동기 필요
    // 재장전
    private bool Key_R = false;             // 개별 동기
    private bool Key_Space = false;         // 개별 동기
    private bool Key_Special = false;             // 특수공격기
    #endregion
    #region 캐릭터가 가지고 있는 자원 이팩트위치나 이팩트 혹은 총알 종류. 추후 수정
    public Transform[] Effect;
    public Transform[] Effectposition;
    public Transform[] ItemEffect;

    public GameObject tempBullet;
    public GameObject FirePoint;
    #endregion
    #region 캐릭터의범위공격 지정.
    [SerializeField]
    public GameObject[] RoundAttack;
    public CloseAttack m_Attack;
    public CloseAttack m_StrongAttack;
    public CloseAttack m_SpecialAttack;
    #endregion
    // 캐릭터를 만들기 위해 아이디를 받는다.
    public void Start()
    {
        Screen.lockCursor = true;

        // 캐릭터 받아오기 세팅
        Player_tr = GetComponent<Transform>();
        Player_rb = GetComponent<Rigidbody>();
        Camera_tr = Camera.main.GetComponent<Transform>();
        _networkView = GetComponent<NetworkView>();

        //캐릭터별 UI 세팅
        Dubu_Special = GameObject.Find("Dubu_Special").GetComponent<Image>();
        Dubu_Right = GameObject.Find("Dubu_Right").GetComponent<Image>();

        Mandu_Special = GameObject.Find("Mandu_Special").GetComponent<Image>();
        Mandu_Right = GameObject.Find("Mandu_Right").GetComponent<Image>();

        Tangsu_Right = GameObject.Find("Tangsu_Right").GetComponent<Image>();
        Tangsu_Special = GameObject.Find("Tangsu_Special").GetComponent<Image>();

        if (config == null)
        {
            config = new ConfigClass();
        }
        // 캐릭터 생성
        switch (Character_ID)
        {
            case Character_Type.Dubu:
                thisCharacter = new DubuCharacter();
                thisAnim = new DubuAnimation();
                CharType = config.DubuString;
                thisCharacter.SetCoroutine(gameObject.AddComponent<DubuCoroutin>());
                //특수기
                m_StrongAttack = RoundAttack[0].GetComponent<DubuAttack>();
                m_StrongAttack.SetEffect(Effect[7]);
                m_SpecialAttack = RoundAttack[1].GetComponent<DubuAttack>();
                m_SpecialAttack.SetEffect(Effect[8]);
                break;
            case Character_Type.Mandu:
                thisCharacter = new ManduCharacter();
                thisAnim = new ManduAnimation();
                CharType = config.ManduString;
                thisCharacter.SetCoroutine(gameObject.AddComponent<ManduCoroutin>());
                //특수기
                m_StrongAttack = RoundAttack[0].GetComponent<ManduAttack>();
                m_StrongAttack.SetEffect(Effect[7]);
                m_SpecialAttack = RoundAttack[1].GetComponent<ManduAttack>();
                m_SpecialAttack.SetEffect(Effect[7]);
                break;
            case Character_Type.Tangsu:
                thisCharacter = new TangsuCharacter();
                thisAnim = new TangsuAnimation();
                CharType = config.TangsuString;
                thisCharacter.SetCoroutine(gameObject.AddComponent<TangsuCoroutin>());
                //특수기
                m_StrongAttack = RoundAttack[0].GetComponent<TangsuAttack>();
                m_StrongAttack.SetEffect(Effect[7]);
                m_SpecialAttack = RoundAttack[1].GetComponent<TangsuAttack>();
                m_SpecialAttack.SetEffect(Effect[8]);
                break;
            default:

                break;
        }
        AttackBuff = false;
        DepanceBuff = false;
        AttackBuffIOverLapping = 0 ;
        DepanceBuffOverLapping = 0;
        SmallBuff = false ;
        SmallBuffOverLapping = 0;
        BigBuff = false;
        BigBuffOverLapping = 0;
        // 세팅
        thisCharacter.SetPlayerOb(gameObject);
        thisCharacter.CharacterTypeString = CharType;
        // 특수기 세팅 
        m_StrongAttack.Player = gameObject.GetComponent<Transform>();
        m_SpecialAttack.Player = gameObject.GetComponent<Transform>();
        m_StrongAttack.Dam = config.StatusConfigs[CharType]["StrongAttack"];
        m_SpecialAttack.Dam = config.StatusConfigs[CharType]["SpecialAttack"];
        m_StrongAttack.ReSetAttack();
        m_SpecialAttack.ReSetAttack();
        thisCharacter.mgr = this;
        thisCharacter.SetPlayerTr(Player_tr);
        thisCharacter.SetPlayerRb(Player_rb);
        thisCharacter.SetCameraTr(Camera_tr);
        thisCharacter.CreateBullet(config.StatusConfigs[CharType]["Cartridge"], tempBullet);
        thisCharacter.SetBulletObject(tempBullet);
        thisAnim.SetMgr(this);
        // 임시
        thisCharacter.SetEffect(Effect);
        thisCharacter.SetEffectPosition(Effectposition);
        // 진짜 컨피그
        Char_Current_HP = config.StatusConfigs[CharType]["HP"];
        Char_Max_HP = config.StatusConfigs[CharType]["HP"];
        // 총구 설정
        FirePoint.transform.localPosition = config.PositionConfig[CharType]["FirePosition"];
        thisCharacter.SetFirePoint(FirePoint);
        thisCharacter.SetAnimator(thisAnim);
        thisAnim.SetChar(thisCharacter);
        thisAnim.SetAnimator(gameObject.GetComponent<Animator>());
        // 캐릭터 마스터 스테이터스
        thisCharacter.SetCharacterStatus(config.StatusConfigs[CharType]);
        MyMgr = GameObject.FindGameObjectWithTag("MGR").GetComponent<GameMgr>();
        //UI
        if (_networkView.isMine)
        {
            switch (Character_ID)
            {
                case Character_Type.Dubu:

                    Dubu_Special.enabled = true;
                    Dubu_Right.enabled = true;
                    break;
                case Character_Type.Mandu:
                    Mandu_Special.enabled = true;
                    Mandu_Right.enabled = true;
                    break;
                case Character_Type.Tangsu:
                    Tangsu_Special.enabled = true;
                    Tangsu_Right.enabled = true;
                    break;
                default:

                    break;
            }
            Debug.Log("이게 기준이 되는 캐릭터");
            HP_image = GameObject.Find("Hp_Image").GetComponent<Image>();
            Cartridge_image = GameObject.Find("Cartridge_Image").GetComponent<Image>();
            Bullet_count = GameObject.Find("Bullet_Count").GetComponent<Text>();
            Right_Black = GameObject.Find("Right_Button_Black").GetComponent<Image>();
            Special_Black = GameObject.Find("Special_Black").GetComponent<Image>();
            Right_Gauge = GameObject.Find("Right_Gauge").GetComponent<Image>();
            Special_Gauge = GameObject.Find("Special_Gauge").GetComponent<Image>();
            Right_Cool = GameObject.Find("Right_Cool").GetComponent<Text>();
            Special_Cool = GameObject.Find("Special_Cool").GetComponent<Text>();

            mainCamera = Camera.main;
            Camera.main.GetComponent<Cam>().SetPlayer(Player_tr);
            GameObject.FindGameObjectWithTag("MGR").GetComponent<NetworkMgr>().SetPlayer(gameObject);
            GameObject.FindGameObjectWithTag("MGR").GetComponent<GameMgr>().MyCharMgr = this;

            if (MyInfoClass.GetInstance().MyGameNumb % 2 == 1)
            {
                mainCamera.GetComponent<Cam>().x = -180;
                mainCamera.GetComponent<Cam>().y = 0;
            }
            else
            {
                mainCamera.GetComponent<Cam>().x = 0;
                mainCamera.GetComponent<Cam>().y = 0;
            }
        }
        Meshs = gameObject.GetComponentsInChildren<SkinnedMeshRenderer>();
        IsCharacterLoaded = true;
        // 무적시작
        StartOverPower();
        thisCharacter.coroutine.StartRespawnMesh();
    }
    public void SetStarted()
    {
        GameObject[] AllPlayer = GameObject.FindGameObjectsWithTag("PLAYER");
        for (int i = 0; i < AllPlayer.Length; i++)
        {
            AllPlayer[i].GetComponent<Transform>().GetComponent<NetworkView>().RPC("Started", RPCMode.AllBuffered, null);
        }
    }
    public void StartOverPower()
    {
        OverPower = true;
        Instantiate(ItemEffect[4], transform.position, Quaternion.identity).SetParent(transform);
        thisCharacter.coroutine.StartOverPower();
    }
    public void EndOverPower()
    {
        OverPower = false;
    }
    [RPC]
    void Started()
    {
        IsInGameSetting = true;
        if (_networkView.isMine)
        {
            thisCharacter.StartFalling();
            StartSetMyInfo();
        }
        Player_rb.useGravity = true;
    }
    private void StartSetMyInfo()
    {
        // 자신의 정보를 모든 Client를 향해 던진다.
        _networkView.RPC("SetMyInfo", RPCMode.AllBuffered, MyInfoClass.GetInstance().MyName, MyInfoClass.GetInstance().MyCharNumb, MyInfoClass.GetInstance().MyGameNumb);
    }
    [RPC]
    public void SetMyInfo(string Name, int CharNumb, int TeamNumb)
    {
        MyName = Name;
        MyTeam = TeamNumb;
        MyCharNumb = CharNumb;
        // 각자 알아서 자신의 정보를 세팅한다.
        MyMgr.AddPlayer(_networkView.viewID, MyName, MyTeam, MyCharNumb);
    }
    public void SetGameEnd()
    {
        GameObject[] AllPlayer = GameObject.FindGameObjectsWithTag("PLAYER");
        for (int i = 0; i < AllPlayer.Length; i++)
        {
            AllPlayer[i].GetComponent<Transform>().GetComponent<NetworkView>().RPC("GameEnd", RPCMode.AllBuffered, null);
        }
    }
    [RPC]
    public void GameEnd()
    {
        MyMgr.MgrGameEnd();
        thisCharacter.CanControll = false;
    }
    void Update()
    {
        //입력을 받고 저장한다.
        if (_networkView.isMine)
        {
            Show_UI();

            Vector3 tempPlayerPosision = Player_tr.position;
            tempPlayerPosision.y += 0.5f;
            Vector3 ToCamera = Camera_tr.position - tempPlayerPosision;
            Cam CamScript = Camera_tr.GetComponent<Cam>();
            if (Physics.Raycast(tempPlayerPosision, ToCamera, CamScript.Dist + 0.2f))
            {
                if (!Physics.Raycast(tempPlayerPosision, ToCamera, CamScript.Dist + 0.15f) || CamScript.Dist <= 0.5f) return;
                CamScript.Dist -= CamScript.Dist > 0.5f ? 0.05f : 0.0f;
            }
            else
            {
                if (Physics.Raycast(tempPlayerPosision, ToCamera, CamScript.Dist + 0.25f) || CamScript.Dist >= 4.0f) return;
                CamScript.Dist += CamScript.Dist < 4f ? 0.05f : 0.0f;
            }
        }
        else
        {
            // PC가 아닌 캐릭터들의 이동 및 회전 선형보간
            /*
            float LerpPosT = ((Time.time - LerpPosStartTime) * LerpSpeed) > 1.0f
                ? 1.0f : ((Time.time - LerpPosStartTime) * LerpSpeed);
            Player_tr.position = Vector3.Lerp(
                Player_tr.position,
                LerpPos,
                LerpPosT
                );
                */
                /*
            PosSyncStartTime += Time.deltaTime;
            Player_tr.position = Vector3.Lerp(Player_tr.position, LerpPos, PosSyncStartTime / PosSyncDelayTime);
            float LerpRotT = ((Time.time - LerpRotStartTime) * LerpSpeed) > 1.0f
                ? 1.0f : ((Time.time - LerpRotStartTime) * LerpSpeed);
            Player_tr.rotation = Quaternion.Lerp(
                Player_tr.rotation,
                LerpRot,
                LerpRotT
                );*/
        }
        // 게임이 시작었고 세팅요청이 왔다. 근데 내쪽에서 인게임 세팅이 안되어있다.-> 로딩이 끝나 게임 시작 요청을 처음 받았음.
        if (IsInGameSetting && !IsGameLoaded)
        {
            IsGameLoaded = true;
        }
        /*
        else
        {
            if (Vector3.Distance(Player_tr.position, Char_Pos) >= 2.0f)
            {
                Player_tr.position = Char_Pos;
                Player_tr.rotation = Char_Rot;
            }
            else
            {
                // 전송받아온 변경된 위치로 부드럽게 이동
                Player_tr.position = Vector3.Lerp(Player_tr.position, Char_Pos, Time.deltaTime * 10.0f);
                // 전송받아온 변경된 각도로 부드럽게 회전
                Player_tr.rotation = Quaternion.Slerp(Player_tr.rotation, Char_Rot, Time.deltaTime * 10.0f);
            }
        }*/
        // 상태에 맞춰서 알아서 애니매이션 플레이
        //thisAnim.PlayAnimation();
        //Debug.DrawLine(FirePoint.transform.position, FirePoint.transform.position + (FirePoint.transform.forward * 10f), Color.cyan);
    }
    public Vector3 ShootTheFuckingRay()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));
        if (Physics.Raycast(ray, out hit, RAY_MaxDist))
        {
            return hit.point;
            //FirePoint.transform.LookAt(hit.point);
        }
        else
        {
            return ray.origin + (Camera.main.transform.forward * 500f);
            //FirePoint.transform.LookAt(ray.origin + (Camera.main.transform.forward * 500f));  
        }
    }
    public void Show_UI()
    {
        //체력
        HP_image.fillAmount = Char_Current_HP / Char_Max_HP;
        //공격
        Current_Bullet = thisCharacter.m_Current_Bullet;
        Max_Bullet = thisCharacter.m_Max_Bullet;
        Bullet_count.text = Current_Bullet + "/" + Max_Bullet;
        Cartridge_image.fillAmount = Current_Bullet / Max_Bullet;
        //강공격
        StrongAttackCoolTime = Mathf.Floor(StrongAttackCoolTime * 10) / 10;
        Right_Gauge.fillAmount = (config.StatusConfigs[CharType]["StrongAttack_CoolTime"] - StrongAttackCoolTime) / config.StatusConfigs[CharType]["StrongAttack_CoolTime"];
        Right_Cool.text = StrongAttackCoolTime.ToString();
        if (StrongAttackCoolTime == 0)
        {
            Right_Cool.enabled = false;
            Right_Black.enabled = false;
            Right_Gauge.sprite = GameObject.Find("FullGauge").GetComponent<Image>().sprite;
        }
        else
        {
            Right_Cool.enabled = true;
            Right_Black.enabled = true;
            Right_Gauge.sprite = GameObject.Find("Gauge").GetComponent<Image>().sprite;
        }
        //특수기
        SpecialAttackCoolTime = Mathf.Floor(SpecialAttackCoolTime * 10) / 10;
        Special_Gauge.fillAmount = (config.StatusConfigs[CharType]["SpecialAttack_CoolTime"] - SpecialAttackCoolTime) / config.StatusConfigs[CharType]["SpecialAttack_CoolTime"];
        Special_Cool.text = SpecialAttackCoolTime.ToString();
        if (SpecialAttackCoolTime == 0)
        {
            Special_Cool.enabled = false;
            Special_Black.enabled = false;
            Special_Gauge.sprite = GameObject.Find("FullGauge").GetComponent<Image>().sprite;
        }
        else
        {
            Special_Cool.enabled = true;
            Special_Black.enabled = true;
            Special_Gauge.sprite = GameObject.Find("Gauge").GetComponent<Image>().sprite;
        }
    }
    [RPC]
    public void SetFirePoint(Vector3 viewPoint)
    {
        FirePoint.transform.LookAt(viewPoint);
        thisCharacter.Attack();
    }
    [RPC]
    public void SetCharacterJump() { thisCharacter.Jump(); }
    [RPC]
    public void SetCharacterReload() { thisCharacter.ReLoad(); }
    public bool GetIsRun() { return thisCharacter.GetIsRun(); }
    [RPC]
    public void GetDamage(float de, NetworkViewID Attacker)
    {
        if (OverPower) return;
        LastAttacker = Attacker;
        if (DepanceBuff) de = de * 0.8f;
        // 만약 방어 버프중이라면
        if (DepanceBuff) de = de * 0.5f;
        Char_Current_HP -= de;
    }
    [RPC]
    public void SetCharacterStrongAttack() { thisCharacter.StrongAttack(); }
    [RPC]
    public void SetCharacterSpecialAttack() { thisCharacter.SpecialAttack(); }
    //도발
    [RPC]
    public void SetCharacterTaunt(int tnumb) { thisCharacter.Taunt(tnumb); }
#region 아이템ㅋㅋㅋ
    public void IGetMyItem()
    {
        if (_networkView.isMine)
        {
            // 얻은 아이템
            int ItemKind = Random.Range(0, 6);
            _networkView.RPC("SetITem", RPCMode.AllBuffered, ItemKind);
        }
    }
    [RPC]
    public void SetITem(int ItemKind)
    {
        thisCharacter.SetItem(20.0f, (CharacterSuper.ItemCode)ItemKind, 0.0f);
    }
#endregion
    // 마우스 올림
    [RPC]
    public void SetMouseUp()
    {
        thisCharacter.UpAttack();
    }
    // 데미지를 전해준다.
    public void ShotPlayer(NetworkView Player, float de)
    {
        if (_networkView.isMine)
        {
            // 만약 같은 팀이라면 쏘지 않는다.
            if (MyMgr.GetTeam(_networkView.viewID) == MyMgr.GetTeam(Player.viewID))
            {
                return;
            }
            // 만약 빅버프가 있다면
            if (BigBuff) de = de * 1.5f;
            // 아니 만약 작은 버프라면
            else if (SmallBuff) de = de * 0.7f;
            // 공격 버프 아이템 사용중이라면
            if (AttackBuff) de = de * 1.35f;
            Player.RPC("GetDamage", RPCMode.AllBuffered, (float)de, _networkView.viewID);
        }
    }
    void FixedUpdate()
    {
        if (_networkView.isMine && !thisCharacter.Is_Dead && Char_Current_HP <= 0)
        {
            thisCharacter.CanControll = false;
            thisCharacter.coroutine.StartRespawn();
            StartDead();
            SendKD();
            return;
        }
        thisCharacter.CharacterUpdate();
        thisCharacter.Check_Ground();
        thisAnim.PlayAnimation();
        if (Player_rb.velocity.y >= 15 && MyInfoClass.GetInstance().MyCharNumb == 0)
        {
            Player_rb.velocity = new Vector3(Player_rb.velocity.x, 0.0f, Player_rb.velocity.z);
        }
        if (_networkView.isMine)
        {
            thisCharacter.SetCharacterMove(Key_H, Key_V);
            if (!thisCharacter.CanControll || thisCharacter.Is_Dead)
            {
                Key_H = 0f;
                Key_V = 0f;
                Click_Left = false;
                Click_Right = false;
                Key_Special = false;
                Key_Shift = false;
                return;
            }
            InputControll();
            thisCharacter.Turn();
        }
        else
        {
            PosSyncStartTime += Time.deltaTime;
            LerpPos = new Vector3(LerpPos.x, Player_tr.position.y + (Player_rb.velocity.y * Time.deltaTime), LerpPos.z);
            if (Player_tr.position.y - LerpPos.y >= 0.2f &&
                Player_tr.position.y - LerpPos.y <= -0.2f)
            {
                Player_tr.position = LerpPos;
            }
            float SyncPosCurrentTime = PosSyncStartTime / PosSyncDelayTime > 1f ? 1.0f : PosSyncStartTime / PosSyncDelayTime;
            Player_tr.position = Vector3.Lerp(Player_tr.position, LerpPos, SyncPosCurrentTime);
            float LerpRotT = ((Time.time - LerpRotStartTime) * LerpSpeed) > 1.0f
                ? 1.0f : ((Time.time - LerpRotStartTime) * LerpSpeed);
            Player_tr.rotation = Quaternion.Lerp(
                Player_tr.rotation,
                LerpRot,
                LerpRotT
                );
        }
    }
    public void SendKD()
    {
        _networkView.RPC("SetKD", RPCMode.AllBuffered, LastAttacker, _networkView.viewID);
    }
    [RPC]
    public void SetKD(NetworkViewID PK, NetworkViewID PD)
    {
        MyMgr.PKPD(PK, PD);
    }
    public void StartDead()
    {
        _networkView.RPC("StartDeadRPC", RPCMode.AllBuffered, null);
    }
    [RPC]
    public void StartDeadRPC()
    {
        thisCharacter.Is_Dead = true;
        // 버프 초기화
        EndBuff(CharacterSuper.ItemCode.Buff_Reset);
        thisCharacter.coroutine.StartDead();
        thisAnim.PlayAnimation();
    }
    public void SetDead()
    {
        for(int i = 0; i < Meshs.Length; i++)
        {
            Meshs[i].enabled = true;
        }
    }
    public void StartRespawn()
    {
        _networkView.RPC("Respawn", RPCMode.AllBuffered, null);
    }
    [RPC]
    public void Respawn()
    {
        thisCharacter.Is_Dead = false;
        thisCharacter.Long_Falling = false;
        Player_tr.position = GameObject.FindGameObjectWithTag("MGR").GetComponent<NetworkMgr>().PlayerCreatePosition[MyInfoClass.GetInstance().MyGameNumb].position;
        Player_tr.rotation = GameObject.FindGameObjectWithTag("MGR").GetComponent<NetworkMgr>().PlayerCreatePosition [MyInfoClass.GetInstance().MyGameNumb].rotation;
        //Player_tr.position = new Vector3(Player_tr.position.x, 10.0f, Player_tr.position.z);
        Start();
        thisCharacter.StartFalling();
    }
    public void InputControll()
    {
        Key_H = Input.GetAxis("Horizontal");
        Key_V = Input.GetAxis("Vertical");

        Click_Left = Input.GetMouseButton(0);
        if (Input.GetMouseButton(0))
        {
            _networkView.RPC("SetFirePoint", RPCMode.AllBuffered, ShootTheFuckingRay());
        }
        if (Input.GetMouseButtonUp(0))
        {
            _networkView.RPC("SetMouseUp", RPCMode.AllBuffered, null);
        }
        Click_Right = Input.GetMouseButton(1);
        if (Input.GetMouseButton(1))
        {
            if (!thisCharacter.Is_StrongAttack && !thisCharacter.Is_SpecialAttack && !thisCharacter.Is_Attack && thisCharacter.GetIsGroud() && !thisCharacter.Is_Taunt1 && !thisCharacter.Is_Taunt2 && StrongAttackCoolTime == 0)
            {
                _networkView.RPC("SetCharacterStrongAttack", RPCMode.AllBuffered, null);
            }
        }
        Key_Special = Input.GetKey(KeyCode.Q);
        if (Input.GetKey(KeyCode.Q))
        {
            if (!thisCharacter.Is_StrongAttack && !thisCharacter.Is_SpecialAttack && !thisCharacter.Is_Attack && !thisCharacter.Is_ReLoad && thisCharacter.GetIsGroud() && !thisCharacter.Is_Taunt1 && !thisCharacter.Is_Taunt2 && SpecialAttackCoolTime == 0)
            {
                _networkView.RPC("SetCharacterSpecialAttack", RPCMode.AllBuffered, null);
            }
        }
        Key_Shift = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        if (Key_Shift && !Click_Left && !Click_Right && !thisCharacter.GetIsReload())
        {
            thisCharacter.SetRun(Key_Shift);
        }
        thisCharacter.SetRun(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift));
        Key_Space = Input.GetKey(KeyCode.Space);
        if (Input.GetKey(KeyCode.Space))
        {
            if (thisCharacter.GetIsGroud() && !thisCharacter.Is_Jump)
            {
                _networkView.RPC("SetCharacterJump", RPCMode.AllBuffered, null);
            }
        }
        Key_R = Input.GetKey(KeyCode.R);
        if (Input.GetKey(KeyCode.R))
        {
            _networkView.RPC("SetCharacterReload", RPCMode.AllBuffered, null);
        }
        Click_Left = Input.GetKeyDown(KeyCode.Alpha1);
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _networkView.RPC("SetCharacterTaunt", RPCMode.AllBuffered, 1);
        }
        Click_Left = Input.GetKeyDown(KeyCode.Alpha2);
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _networkView.RPC("SetCharacterTaunt", RPCMode.AllBuffered, 2);
        }
    }
    public void PlayAnimation()
    {
        thisAnim.PlayMove();
        // 공격 애니매이션

        // 재장전 애니매이션
    }

    public void SetCharID(Character_Type Code) { Character_ID = Code; }

    // 게임을 끝내로 왔다.
    public void DisConnectInClient()
    {
        GameObject[] AllPlayer = GameObject.FindGameObjectsWithTag("PLAYER");
        for (int i = 0; i < AllPlayer.Length; i++)
        {
            if (AllPlayer[i] == gameObject) continue;
            AllPlayer[i].GetComponent<Transform>().GetComponent<NetworkView>().RPC("ClientDisconnect", RPCMode.AllBuffered, null);
        }
    }
    [RPC]
    public void ClientDisconnect()
    {
        Network.Disconnect();
        MasterServer.UnregisterHost();
    }
    public void SetBuff(CharacterSuper.ItemCode Code)
    {
        switch (Code)
        {
            case CharacterSuper.ItemCode.Buff_Attack:
                if (AttackBuff) AttackBuffIOverLapping += 1;
                else
                {
                    AttackBuff = true;
                    AttackBuffEffect = Instantiate(ItemEffect[0], transform.position, Quaternion.identity);
                    AttackBuffEffect.SetParent(transform);
                }
                break;
            case CharacterSuper.ItemCode.Buff_Depance:
                if (DepanceBuff) DepanceBuffOverLapping += 1;
                else
                {
                    DepanceBuff = true;
                    DepanceBuffEffect = Instantiate(ItemEffect[1], transform.position, Quaternion.identity);
                    DepanceBuffEffect.SetParent(transform);
                }
                break;

            case CharacterSuper.ItemCode.Buff_Hill:
                Instantiate(ItemEffect[2], transform.position, Quaternion.identity).SetParent(transform);
                break;
            case CharacterSuper.ItemCode.Buff_Small:
                // 만약 캐릭터가 이미 빅버프를 가지고 있다
                if (BigBuff)
                {
                    BigBuffOverLapping = 0;
                    BigBuff = false;
                }
                if (SmallBuff) SmallBuffOverLapping += 1;
                else
                {
                    // 캐릭터 크기를 줄여준다
                    transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                }
                SmallBuff = true;
                break;
            case CharacterSuper.ItemCode.Buff_Big:
                // 만일 캐릭터가 스몰 버프를 가지고 있다면.
                if (SmallBuff)
                {
                    SmallBuffOverLapping = 0;
                    SmallBuff = false;
                }
                if (BigBuff) BigBuffOverLapping += 1;
                else
                {
                    //캐릭터 크기를 키운다.
                    transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                }
                BigBuff = true;
                break;
            case CharacterSuper.ItemCode.Buff_CoolDown:
                Instantiate(ItemEffect[3], transform.position, Quaternion.identity).SetParent(transform);
                break;
            default:
                break;
        }
    }
    public void EndBuff(CharacterSuper.ItemCode Code)
    {
        switch (Code)
        {
            case CharacterSuper.ItemCode.Buff_Attack:
                if (AttackBuffIOverLapping != 0) AttackBuffIOverLapping -= 1;
                else
                {
                    AttackBuff = false;
                    //Destroy(AttackBuffEffect);
                    AttackBuffEffect.GetComponent<ItemDestroy>().DestroyMe();
                }
                break;
            case CharacterSuper.ItemCode.Buff_Depance:
                if (DepanceBuffOverLapping != 0) DepanceBuffOverLapping -= 1;
                else
                {
                    DepanceBuff = false;
                    //Destroy(DepanceBuffEffect);
                    DepanceBuffEffect.GetComponent<ItemDestroy>().DestroyMe();
                }
                break;

            case CharacterSuper.ItemCode.Buff_Hill:

                break;
            case CharacterSuper.ItemCode.Buff_Small:
                if (SmallBuffOverLapping != 0)
                {
                    SmallBuffOverLapping -= 1;
                }
                else if (SmallBuff)
                {
                    //캐릭터 크기를 원상복구 한다.
                    transform.localScale = new Vector3(1, 1, 1);
                    SmallBuff = false;
                }
                break;
            case CharacterSuper.ItemCode.Buff_Big:
                if (BigBuffOverLapping != 0)
                {
                    BigBuffOverLapping -= 1;
                }
                else if (BigBuff)
                {
                    // 캐릭터 크기를 원상복구 한다.
                    transform.localScale = new Vector3(1, 1, 1);
                    BigBuff = false;
                }
                break;
            case CharacterSuper.ItemCode.Buff_CoolDown:

                break;
            default:
                if (AttackBuff)
                {
                    AttackBuffIOverLapping = 0;
                    AttackBuff = false;
                    Destroy(AttackBuffEffect);
                }
                if (DepanceBuff)
                {
                    DepanceBuffOverLapping = 0;
                    DepanceBuff = false;
                    Destroy(DepanceBuffEffect);
                }
                if (BigBuff)
                {
                    BigBuffOverLapping = 0;
                    BigBuff = false;
                    transform.localScale = new Vector3(1, 1, 1);
                }
                if (SmallBuff)
                {
                    SmallBuff = false;
                    SmallBuffOverLapping = 0;
                    transform.localScale = new Vector3(1, 1, 1);
                }
                break;
        }
    }
    #region RPC함수
    // 플레이어의 타겟이 맞았을때
    [RPC]
    public void HitTheTarget(NetworkView temp)
    {

    }
    [RPC]
    public void KeyEvent()
    {

    }
    #endregion
    #region 네트워크 콜백
    void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
    {
        if (!IsCharacterLoaded) return;

        Vector3 TempVel = Vector3.zero;
        float Speed = 0.0f;//thisCharacter.CharSpeed;
        if (stream.isWriting)
        {
            // 임시 각자의 코드 값 세팅
            //int CharCode = MyMgr.GetPlayerCode();

            // 위치, 각도
            Vector3 pos = Player_tr.position;
            Quaternion rot = Player_tr.rotation;

            float posx = Player_tr.position.x;
            float posz = Player_tr.position.z;

            TempVel = new Vector3(Player_rb.velocity.x,0.0f,Player_rb.velocity.z);

            float H = Key_H;
            float V = Key_V;
            bool check = thisCharacter.GetIsGroud();
            // 키 동기화
            Key_Shift = thisCharacter.GetIsRun();
            Speed = thisCharacter.CharSpeed;
            // 위치 전송
            //stream.Serialize(ref pos);
            stream.Serialize(ref posx);
            stream.Serialize(ref posz);
            stream.Serialize(ref rot);
            stream.Serialize(ref TempVel);
            // 키동기 -> 움직임등의 연속적인 것들만 동기화 시킨다.
            stream.Serialize(ref H);
            stream.Serialize(ref V);
            stream.Serialize(ref check);
            stream.Serialize(ref Speed);
        }
        else
        {
            // 임시 코드
            int CodeTemp = 0;

            Vector3 revPos = Vector3.zero;
            Quaternion revRot = Quaternion.identity;

            float posx = 0.0f;
            float posz = 0.0f;

            float recvh = 0.0f;
            float recvv = 0.0f;
            bool check = false;
            // 캐릭터 코드 수신.
            //stream.Serialize(ref CodeTemp);

            // 데이터 수신
            //stream.Serialize(ref revPos);
            stream.Serialize(ref posx);
            stream.Serialize(ref posz);
            stream.Serialize(ref revRot);
            stream.Serialize(ref TempVel);
            // 이동키
            stream.Serialize(ref recvh);
            stream.Serialize(ref recvv);
            stream.Serialize(ref check);
            stream.Serialize(ref Speed);
            // 플레이어 코드 업데이트
            //thisCharacter.SetPlayerCode(CodeTemp);

            //Player_tr.position = revPos;
            //Player_tr.rotation = revRot;
            // 네트워크에서 들어온값이 내가 가진값과 차이가 난다.
            //LerpPosStartTime = 0.0f;
            PosSyncStartTime = 0.0f;
            PosSyncDelayTime = Time.time - LastSyncTime;
            LerpPos = new Vector3(posx, Player_tr.position.y/* + (Player_rb.velocity.y * Time.deltaTime)*/, posz);// + TempVel * PosSyncDelayTime;
            //LerpPos = revPos + TempVel * PosSyncDelayTime;
            /*
            float PosDistance = Vector3.Distance(LerpPos, revPos);
            if (PosDistance > 0)
            {
                //값을 초기화 하고 러프를 시작한다.
                LerpPos = revPos;
                LerpPosStartTime = Time.time;
            }*/
            if (revRot != LerpRot)
            {
                LerpRot = revRot;
                LerpRotStartTime = Time.time;
            }
            Key_H = recvh;
            Key_V = recvv;
            thisCharacter.SetCheckGround(check);
            //if (thisCharacter == null) return;
            //thisCharacter.SetRun(recvshift);
            thisCharacter.CharSpeed = Speed;
            LastSyncTime = Time.time;
        }
    }
    [RPC]
    public void TempTangsuAttack2()
    {
        TangsuCharacter temp = (TangsuCharacter)thisCharacter;
        temp.TangsuCorutine.StartAttack2();
    }
    [RPC]
    public void TempTangsuAttack3()
    {
        TangsuCharacter temp = (TangsuCharacter)thisCharacter;
        temp.TangsuCorutine.StartAttack3();
    }
    #endregion
}
