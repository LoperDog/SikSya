using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigClass {
    #region 게임전체에 쓰일 부분
    public enum GameState
    {
        NoSession,
        Matching,
        InRoom,
        InGame,
        NotStart,
    };

    #endregion
    public Dictionary<string, float> ManduStatus = new Dictionary<string, float>();
    public Dictionary<string, float> DubuStatus = new Dictionary<string, float>();
    public Dictionary<string, float> TangsuStatus = new Dictionary<string, float>();
    public Dictionary<string, Dictionary<string,float>> StatusConfigs = new Dictionary<string, Dictionary<string, float>>();

    public Dictionary<string, Vector3> ManduPosition = new Dictionary<string, Vector3>();
    public Dictionary<string, Vector3> DubuPosition = new Dictionary<string, Vector3>();
    public Dictionary<string, Vector3> TangsuPosition = new Dictionary<string, Vector3>();
    public Dictionary<string, Dictionary<string, Vector3>> PositionConfig = new Dictionary<string, Dictionary<string, Vector3>>();

    public string ManduString = "Mandu";
    public string DubuString = "Dubu";
    public string TangsuString = "Tangsu";
    
    public ConfigClass()
    {
        #region 만두콘피그
        ManduStatus["HP"] = 200f; //체력

        ManduStatus["MoveSpeed"] = 2.0f;
        ManduStatus["RunSpeed"] = 5.0f;
        ManduStatus["JumpForce"] = 13f;

        ManduStatus["Cartridge"] = 7f;//장탄수
        ManduStatus["ReLoadTime"] = 3.14f;

        ManduStatus["Attack"] = 50f;
        ManduStatus["AtttackSpeed"] = 1.9f;

        ManduStatus["StrongAttack"] = 120f;//우클릭 공격력
        ManduStatus["StrongAttack_CoolTime"] = 2.0f;//우클릭 쿨타임
        ManduStatus["StongAttackTime"] = 0.5f;

        ManduStatus["SpecialAttack"] = 220.0f;//Q스킬 공격력
        ManduStatus["SpecialAttack_CoolTime"] = 40.0f;// Q스킬 쿨타임
        ManduStatus["SpecialAttackReady"] = 1.5f;
        ManduStatus["SpecialAttackTime"] = 1.9f;

        ManduStatus["Taunt1"] = 3.2f;
        ManduStatus["Taunt2"] = 3.83f;

        ManduPosition.Add("FirePosition", new Vector3(0.2f, 0.9f, 1.3f));
        #endregion

        #region 두부콘피그
        DubuStatus["HP"] = 100f;//체력

        DubuStatus["MoveSpeed"] = 2.5f;
        DubuStatus["RunSpeed"] = 7.0f;
        DubuStatus["JumpForce"] = 10;

        DubuStatus["Cartridge"] = 50f;//장탄수
        DubuStatus["ReLoadTime"] = 1.7f;

        DubuStatus["Attack"] = 8f;//공격력
        DubuStatus["AtttackSpeed"] = 0.25f;

        DubuStatus["StrongAttack"] = 80f;//우클릭 공격력
        DubuStatus["StrongAttack_CoolTime"] = 8.0f;//우클릭 쿨타임

        DubuStatus["StongAttackReady"] = 0.2f;
        DubuStatus["StongAttackEnd"] = 0.6f;

        DubuStatus["SpecialAttack"] = 150.0f;//Q스킬 대미지
        DubuStatus["SpecialAttack_CoolTime"] = 30.0f;//Q스킬 쿨타임

        DubuStatus["SpecialAttackReady"] = 0.86f;
        DubuStatus["SpecialAttackTime"] = 0.56f;
        DubuStatus["SpecialAttackEnd"] = 1.43f;

        DubuStatus["Taunt1"] = 3.0f;
        DubuStatus["Taunt2"] = 1.3f;

        DubuPosition.Add("FirePosition", new Vector3(0.0f, 1.15f, 0.8f));
        #endregion

        #region 탕수콘피그
        TangsuStatus["HP"] = 150f;//체력

        TangsuStatus["MoveSpeed"] = 3.0f;
        TangsuStatus["RunSpeed"] = 8.0f;
        TangsuStatus["JumpForce"] = 13;

        TangsuStatus["Cartridge"] = 0f;//근접공격이라 장탄수 없음
        TangsuStatus["ReLoadTime"] = 0f;//재장전 안해
        TangsuStatus["Attack"] = 50f;//공격력
        TangsuStatus["AtttackSpeed"] = 0.25f;

        TangsuStatus ["Atttack1_Start"] = 0.33f;
        TangsuStatus ["Atttack1_End"] = 1.07f;

        TangsuStatus ["Atttack2_Start"] = 0.33f;
        TangsuStatus ["Atttack2_End"] = 0.9f;

        TangsuStatus ["Atttack3_Start"] = 0.5f;
        TangsuStatus ["Atttack3_End"] = 1.16f;

        TangsuStatus ["StrongAttack"] = 30f;//우클릭 공격력
        TangsuStatus["StrongAttack_CoolTime"] = 5.0f;//우클릭 쿨타임

        TangsuStatus["SpecialAttack"] = 150.0f;//Q스킬 대미지
        TangsuStatus["SpecialAttack_CoolTime"] = 25.0f;//Q스킬 쿨타임

        TangsuStatus ["SpecialAttack_Ready"] = 0.9f;//공격 순간
        TangsuStatus ["SpecialAttack_End"] = 1.2f;//공격부터 끝나는 시간

        TangsuStatus["Taunt1"] = 2.7f;
        TangsuStatus["Taunt2"] = 3.3f;

        TangsuPosition.Add("FirePosition", new Vector3(0.0f, 0.0f, 0.0f));

        #endregion

        // 콘피그 적용. 
        StatusConfigs.Add(ManduString, ManduStatus);
        StatusConfigs.Add(DubuString, DubuStatus);
        StatusConfigs.Add(TangsuString, TangsuStatus);
        PositionConfig.Add(ManduString, ManduPosition);
        PositionConfig.Add(DubuString, DubuPosition);
        PositionConfig.Add(TangsuString, TangsuPosition);
    }
}
