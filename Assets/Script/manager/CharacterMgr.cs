using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMgr : MonoBehaviour
{
    public Camera mainCamera;

    [SerializeField]
    public ConfigClass config;

    public Transform Player_tr;
    private Rigidbody Player_rb;
    private Transform Camera_tr;

    private NetworkView _networkView;
    private Vector3 Char_Pos;
    private Quaternion Char_Rot;

    string CharType = "";
    [SerializeField]
    Dictionary<string, GameObject> TempBulletPool;
    [SerializeField]
    List<GameObject> LoadChar;

    [SerializeField]
    public List<GameObject> LoadBullet;
    [SerializeField]
    public GameMgr MyMgr;

    //공용UI
    public Text Bullet_count;
    public Image Special;
    public Image HP_image;
    public Image Right_Black;
    public Text Right_Cool;
    public Text Special_Cool;

    //캐릭터별 UI
    public Image Dubu;
    public Image Dubu_dead;
    public Image Mandu;
    public Image Mandu_dead;
    public Image Dubu_Special;
    public Image Mandu_Special;
    public Image Dubu_Right;
    public Image Mandu_Right;

    // 네트워크에서 약간의 딜레이가 들어간 움직임 목표점.
    private Vector3 LerpPos;
    private Quaternion LerpRot;
    private float LerpSpeed = 5.0f;
    private float LerpPosStartTime = 0.0f;
    private float LerpRotStartTime = 0.0f;

    // 캐릭터 리스트가 필요하다.

    public enum Chacracter_Type
    {
        Dubu,
        Mandu
    };
    public string MyName;
    public int MyTeam;
    public int MyCharNumb;

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

    public float RAY_MaxDist = 500;

    private bool IsCharacterLoaded = false; // 캐릭터 세팅이 끝났는가?
    private bool IsGameLoaded = false;      // 게임로딩이 끝났는가?
    private bool IsInGameSetting = false;   // 요청이 떨어졌는가?

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
    private Chacracter_Type Character_ID;

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
    }
    private float Key_V = 0.0f;
    public float keyv
    {
        get { return Key_V; }
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

    public GameObject tempBullet;
    public GameObject FirePoint;
    #endregion
    #region 캐릭터의범위공격 지정.
    [SerializeField]
    public GameObject[] RoundAttack;
    public CloseAttack m_StrongAttack;
    public CloseAttack m_SpecialAttack;
    #endregion
    // 캐릭터를 만들기 위해 아이디를 받는다.
    public void Start()
    {
        // 캐릭터 받아오기 세팅
        Player_tr = GetComponent<Transform>();
        Player_rb = GetComponent<Rigidbody>();
        Camera_tr = Camera.main.GetComponent<Transform>();
        _networkView = GetComponent<NetworkView>();

        //캐릭터별 UI 세팅
        Dubu = GameObject.Find("Dubu").GetComponent<Image>();
        Dubu_dead = GameObject.Find("Dubu_dead").GetComponent<Image>();
        Dubu_Special = GameObject.Find("Dubu_Special").GetComponent<Image>();
        Dubu_Right = GameObject.Find("Dubu_Right").GetComponent<Image>();

        Mandu = GameObject.Find("Mandu").GetComponent<Image>();
        Mandu_dead = GameObject.Find("Mandu_dead").GetComponent<Image>();
        Mandu_Special = GameObject.Find("Mandu_Special").GetComponent<Image>();
        Mandu_Right = GameObject.Find("Mandu_Right").GetComponent<Image>();

        if (config == null)
        {
            config = new ConfigClass();
        }
        //
        Screen.lockCursor = true;
        // 캐릭터 생성
        switch (Character_ID)
        {
            case Chacracter_Type.Dubu:
                thisCharacter = new DubuCharacter();
                thisAnim = new DubuAnimation();
                CharType = config.DubuString;
                thisCharacter.SetCoroutine(gameObject.AddComponent<DubuCoroutin>());
                //특수기
                m_StrongAttack = RoundAttack[0].GetComponent<DubuAttack>();
                m_SpecialAttack = RoundAttack[1].GetComponent<DubuAttack>();
                break;
            case Chacracter_Type.Mandu:
                thisCharacter = new ManduCharacter();
                thisAnim = new ManduAnimation();
                CharType = config.ManduString;
                thisCharacter.SetCoroutine(gameObject.AddComponent<ManduCoroutin>());
                //특수기
                m_StrongAttack = RoundAttack[0].GetComponent<ManduAttack>();
                m_SpecialAttack = RoundAttack[1].GetComponent<ManduAttack>();
                break;
            default:

                break;
        }
        // 세팅
        thisCharacter.SetPlayerOb(gameObject);
        // 특수기 세팅 
        m_StrongAttack.Player = gameObject.GetComponent<Transform>();
        m_SpecialAttack.Player = gameObject.GetComponent<Transform>();
        m_StrongAttack.Dam = config.StatusConfigs[CharType]["StrongAttack"];
        m_SpecialAttack.Dam = config.StatusConfigs[CharType]["SpecialAttack"];
        m_StrongAttack.ReSetAttack();
        m_SpecialAttack.ReSetAttack();
        //thisCharacter.SetCoroutine(gameObject.AddComponent<DubuCoroutin>());
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
        // 캐릭터 마스터 스테이터스,
        thisCharacter.SetCharacterStatus(config.StatusConfigs[CharType]);
        MyMgr = GameObject.FindGameObjectWithTag("MGR").GetComponent<GameMgr>();
        //UI
        if (_networkView.isMine)
        {
            switch (Character_ID)
            {
                case Chacracter_Type.Dubu:
                    Dubu.enabled = true;
                    Dubu_dead.enabled = true;
                    Dubu_Special.enabled = true;
                    Dubu_Right.enabled = true;
                    break;
                case Chacracter_Type.Mandu:
                    Mandu.enabled = true;
                    Mandu_dead.enabled = true;
                    Mandu_Special.enabled = true;
                    Mandu_Right.enabled = true;
                    break;
                default:

                    break;
            }
            Debug.Log("이게 기준이 되는 캐릭터");
            HP_image = GameObject.Find("Hp_Image").GetComponent<Image>();
            Bullet_count = GameObject.Find("Bullet_Count").GetComponent<Text>();
            Special = GameObject.Find("Special_Black").GetComponent<Image>();
            Right_Black = GameObject.Find("Right_Button_Black").GetComponent<Image>();
            Right_Cool = GameObject.Find("Right_Cool").GetComponent<Text>();
            Special_Cool = GameObject.Find("Special_Cool").GetComponent<Text>();
            Camera.main.GetComponent<Cam>().SetPlayer(Player_tr);
            mainCamera = Camera.main;
            GameObject.FindGameObjectWithTag("MGR").GetComponent<NetworkMgr>().SetPlayer(gameObject);
        }
        IsCharacterLoaded = true;
    }
    public void SetStarted()
    {
        GameObject[] AllPlayer = GameObject.FindGameObjectsWithTag("PLAYER");
        for (int i = 0; i < AllPlayer.Length; i++)
        {
            AllPlayer[i].GetComponent<Transform>().GetComponent<NetworkView>().RPC("Started", RPCMode.AllBuffered, null);
        }
    }
    [RPC]
    void Started()
    {
        IsInGameSetting = true;
        if (_networkView.isMine)
        {
            Player_rb.useGravity = true;
            // 메니저에 플레이어들을 세팅 시킨다.
            MyMgr.StartGetGamePlayerInfo();
            // 자신의 정보를 네트워크를 통해 넘긴다.
            StartSetMyInfo();
        }
    }
    private void StartSetMyInfo()
    {
        // 자신의 정보를 모든 Client를 향해 던진다.
        _networkView.RPC("SetMyInfo", RPCMode.AllBuffered, MyInfoClass.GetInstance().MyName, MyInfoClass.GetInstance().MyCharNumb, MyInfoClass.GetInstance().MyGameNumb % 2);
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
    void Update()
    {
        //캐릭터 업데이트
        //thisCharacter.CharacterUpdate();

        //입력을 받고 저장한다.
        if (_networkView.isMine)
        {
            Show_UI();
        }
        else
        {
            // PC가 아닌 캐릭터들의 이동 및 회전 선형보간
            float LerpPosT = ((Time.time - LerpPosStartTime) * LerpSpeed) > 1.0f 
                ? 1.0f : ((Time.time - LerpPosStartTime) * LerpSpeed);
            Player_tr.position = Vector3.Lerp(
                Player_tr.position,
                LerpPos,
                LerpPosT
                );

            float LerpRotT = ((Time.time - LerpRotStartTime) * LerpSpeed) > 1.0f 
                ? 1.0f : ((Time.time - LerpRotStartTime) * LerpSpeed);
            Player_tr.rotation = Quaternion.Lerp(
                Player_tr.rotation,
                LerpRot,
                LerpRotT
                );
        }
        // 게임이 시작었고 세팅요청이 왔다. 근데 내쪽에서 인게임 세팅이 안되어있다.-> 로딩이 끝나 게임 시작 요청을 처음 받았음.
        if (IsInGameSetting && !IsGameLoaded)
        {
            IsGameLoaded = true;
            thisCharacter.CanControll = true;
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
        //강공격
        StrongAttackCoolTime = Mathf.Floor(StrongAttackCoolTime * 10) / 10;
        Right_Black.fillAmount = StrongAttackCoolTime / config.StatusConfigs[CharType]["StrongAttack_CoolTime"];
        Right_Cool.text = StrongAttackCoolTime.ToString();
        if (StrongAttackCoolTime <= 0.1)
        {
            Right_Cool.enabled = false;
        }
        else
        {
            Right_Cool.enabled = true;
        }
        //특수기
        SpecialAttackCoolTime = Mathf.Floor(SpecialAttackCoolTime * 10) / 10;
        Special.fillAmount = SpecialAttackCoolTime / config.StatusConfigs[CharType]["SpecialAttack_CoolTime"];
        Special_Cool.text = SpecialAttackCoolTime.ToString();
        if (SpecialAttackCoolTime == 0)
        {
            Special_Cool.enabled = false;
        }
        else
        {
            Special_Cool.enabled = true;
        }
    }
    [RPC]
    public void SetFirePoint(Vector3 viewPoint)
    {
        FirePoint.transform.LookAt(viewPoint);
        thisCharacter.Attack();
    }
    [RPC]
    public void SetCharacterJump()
    {
        thisCharacter.Jump();
    }
    [RPC]
    public void SetCharacterReload()
    {
        thisCharacter.ReLoad();
    }
    [RPC]
    public void GetDamage(float de)
    {
        //Debug.Log("맞은 아이디 : " + _networkView.viewID + " 남은 채력 : " + Char_Current_HP);
        Char_Current_HP -= de;
    }
    // 강공격
    [RPC]
    public void SetCharacterStAttack()
    {
        thisCharacter.StrongAttack();
    }
    // 특수기
    [RPC]
    public void SetCharacterSpecialAttack()
    {
        thisCharacter.SpecialAttack();
    }
    //도발
    [RPC]
    public void SetCharacterTaunt(int tnumb)
    {
        thisCharacter.Taunt(tnumb);
    }
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
                Debug.Log("같은 팀을 쏘고 있다.");
                return;
            }
            Player.RPC("GetDamage", RPCMode.AllBuffered, (float)de);
        }
    }
    void FixedUpdate()
    {
        if (_networkView.isMine && !thisCharacter.Is_Dead && Char_Current_HP <= 0)
        {
            StartDead();
            thisCharacter.CanControll = false;
            thisCharacter.coroutine.StartRespawn();
            return;
        }
        thisCharacter.CharacterUpdate();
        thisAnim.PlayAnimation();
        if (_networkView.isMine)
        {
            thisCharacter.SetCharacterMove(Key_H, Key_V);
            if (!thisCharacter.CanControll)
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
    }
    public void StartDead()
    {
        _networkView.RPC("StartDeadRPC", RPCMode.AllBuffered, null);
    }
    [RPC]
    public void StartDeadRPC()
    {
        thisCharacter.Is_Dead = true;
        thisAnim.PlayAnimation();
    }
    public void StartRespawn()
    {
        _networkView.RPC("Respawn", RPCMode.AllBuffered, null);
    }
    [RPC]
    public void Respawn()
    {
        Debug.Log("캐릭터 리스폰 시작");
        thisCharacter.Is_Dead = false;
        thisCharacter.Long_Falling = false;
        Player_tr.position = GameObject.FindGameObjectWithTag("MGR").GetComponent<NetworkMgr>().PlayerCreatePosition[MyInfoClass.GetInstance().MyGameNumb];
        Start();
        // 애니매이터 시작시켜준다.
        thisCharacter.CanControll = true;
        Debug.Log("리스폰 끝");
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
            _networkView.RPC("SetCharacterStAttack", RPCMode.AllBuffered, null);
        }
        Key_Special = Input.GetKey(KeyCode.Q);
        if (Input.GetKey(KeyCode.Q))
        {
            _networkView.RPC("SetCharacterSpecialAttack", RPCMode.AllBuffered, null);
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
            //_networkView.RPC("SetCharacterJump", RPCMode.AllBuffered, null);
            thisCharacter.Jump();
        }
        Key_Space = Input.GetKey(KeyCode.R);
        if (Input.GetKey(KeyCode.R))
        {
            CharacterReLoad();
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
    public void CharacterReLoad()
    {
        _networkView.RPC("SetCharacterReload", RPCMode.AllBuffered, null);
    }
    public void PlayAnimation()
    {
        thisAnim.PlayMove();
        // 공격 애니매이션

        // 재장전 애니매이션
    }

    public void SetCharID(Chacracter_Type Code) { Character_ID = Code; }
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
        //if (thisCharacter == null) return;
        if (stream.isWriting)
        {
            // 임시 각자의 코드 값 세팅
            //int CharCode = MyMgr.GetPlayerCode();

            // 위치, 각도
            Vector3 pos = Player_tr.position;
            Quaternion rot = Player_tr.rotation;

            float H = Key_H;
            float V = Key_V;
            bool Shift = Key_Shift;

            // 키 동기화
            Key_Shift = thisCharacter.GetIsRun();

            // 위치 전송
            stream.Serialize(ref pos);
            stream.Serialize(ref rot);

            // 키동기 -> 움직임등의 연속적인 것들만 동기화 시킨다.
            stream.Serialize(ref H);
            stream.Serialize(ref V);
            stream.Serialize(ref Shift);
        }
        else
        {
            // 임시 코드
            int CodeTemp = 0;

            Vector3 revPos = Vector3.zero;
            Quaternion revRot = Quaternion.identity;

            float recvh = 0.0f;
            float recvv = 0.0f;
            bool recvshift = false;

            // 캐릭터 코드 수신.
            //stream.Serialize(ref CodeTemp);

            // 데이터 수신
            stream.Serialize(ref revPos);
            stream.Serialize(ref revRot);

            // 이동키
            stream.Serialize(ref recvh);
            stream.Serialize(ref recvv);
            stream.Serialize(ref recvshift);

            // 플레이어 코드 업데이트
            //thisCharacter.SetPlayerCode(CodeTemp);

            //Player_tr.position = revPos;
            //Player_tr.rotation = revRot;
            // 네트워크에서 들어온값이 내가 가진값과 차이가 난다.
            float PosDistance = Vector3.Distance(LerpPos, revPos);
            if (PosDistance > Mathf.Epsilon)
            {
                //값을 초기화 하고 러프를 시작한다.
                LerpPos = revPos;
                LerpPosStartTime = Time.time;
            }
            if(revRot != LerpRot)
            {
                LerpRot = revRot;
                LerpRotStartTime = Time.time;
            }
            Key_H = recvh;
            Key_V = recvv;
            if (thisCharacter == null) return;
            thisCharacter.SetRun(recvshift);
        }
    }
    #endregion
}
