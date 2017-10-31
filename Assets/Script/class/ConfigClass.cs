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
    public Dictionary<string, Dictionary<string,float>> StatusConfigs = new Dictionary<string, Dictionary<string, float>>();
    public Dictionary<string, Vector3> ManduPosition = new Dictionary<string, Vector3>();
    public Dictionary<string, Vector3> DubuPosition = new Dictionary<string, Vector3>();
    public Dictionary<string, Dictionary<string, Vector3>> PositionConfig = new Dictionary<string, Dictionary<string, Vector3>>();

    public string ManduString = "Mandu";
    public string DubuString = "Dubu";
    
    public ConfigClass()
    {
        #region 만두콘피그
        ManduStatus["HP"] = 150f; //체력

        ManduStatus["MoveSpeed"] = 1.5f;
        ManduStatus["RunSpeed"] = 3.5f;
        ManduStatus["JumpForce"] = 1500f;

        ManduStatus["Cartridge"] = 7f;//장탄수 수정
        ManduStatus["ReLoadTime"] = 3.14f;

        ManduStatus["Attack"] = 50f;
        ManduStatus["AtttackSpeed"] = 1.9f;

        ManduStatus["StrongAttack"] = 150f;//우클릭 공격력
        ManduStatus["StrongAttack_CoolTime"] = 10.0f;//우클릭 쿨타임
        ManduStatus["StongAttackTime"] = 0.5f;

        ManduStatus["SpecialAttack"] = 200.0f;//Q스킬 공격력
        ManduStatus["SpecialAttack_CoolTime"] = 30.0f;// Q스킬 쿨타임
        ManduStatus["SpecialAttackReady"] = 1.5f;
        ManduStatus["SpecialAttackTime"] = 1.9f;

        ManduStatus["Taunt1"] = 3.2f;
        ManduStatus["Taunt2"] = 3.83f;

        ManduPosition.Add("FirePosition", new Vector3(0.2f, 0.9f, 1.3f));
        #endregion

        #region 두부콘피그
        DubuStatus["HP"] = 100f;//체력

        DubuStatus["MoveSpeed"] = 2.0f;
        DubuStatus["RunSpeed"] = 6.0f;
        DubuStatus["JumpForce"] = 1500;
        // 장탄수
        DubuStatus["Cartridge"] = 50f;//장탄수
        DubuStatus["ReLoadTime"] = 1.7f;

        DubuStatus["Attack"] = 10f;//공격력
        DubuStatus["AtttackSpeed"] = 0.25f;

        DubuStatus["StrongAttack"] = 30f;//우클릭 공격력
        DubuStatus["StrongAttack_CoolTime"] = 5.0f;//우클릭 쿨타임
        DubuStatus["StongAttackReady"] = 0.26f;
        DubuStatus["StongAttackTime"] = 0.23f;
        DubuStatus["StongAttackEnd"] = 0.57f;

        DubuStatus["SpecialAttack"] = 100.0f;//Q스킬 대미지
        DubuStatus["SpecialAttack_CoolTime"] = 25.0f;//Q스킬 쿨타임
        DubuStatus["SpecialAttackReady"] = 0.86f;
        DubuStatus["SpecialAttackTime"] = 0.56f;
        DubuStatus["SpecialAttackEnd"] = 1.43f;

        DubuStatus["Taunt1"] = 3.0f;
        DubuStatus["Taunt2"] = 1.3f;

        DubuPosition.Add("FirePosition", new Vector3(0.0f, 1.15f, 0.8f));
        #endregion

        // 콘피그 적용. 
        StatusConfigs.Add(ManduString, ManduStatus);
        StatusConfigs.Add(DubuString, DubuStatus);
        PositionConfig.Add(ManduString, ManduPosition);
        PositionConfig.Add(DubuString, DubuPosition);
    }
}
