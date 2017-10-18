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
        ManduStatus["HP"] = 150f;

        ManduStatus["MoveSpeed"] = 1.5f;//수정 X
        ManduStatus["RunSpeed"] = 3.5f;//수정 X
        ManduStatus["JumpForce"] = 1500f;//수정X

        ManduStatus["Cartridge"] = 7f; //장탄 수
        ManduStatus["ReLoadTime"] = 3.14f;//수정X

        ManduStatus["Attack"] = 50f;
        ManduStatus["AtttackSpeed"] = 1.9f;

        ManduStatus["StrongAttack"] = 50f;
        ManduStatus["StrongAttack_CoolTime"] = 10.0f;

        ManduStatus["SpecialAttack"] = 100.0f;
        ManduStatus["SpecialAttack_CoolTime"] = 30.0f;
        ManduStatus["SpecialAttackTime"] = 3.4f;//수정X

        ManduStatus["Taunt1"] = 3.2f;//수정X
        ManduStatus["Taunt2"] = 3.83f;//수정X

        ManduPosition.Add("FirePosition", new Vector3(0.0f, 0.9f, 0.8f));
        #endregion

        #region 두부콘피그
        DubuStatus["HP"] = 100f;

        DubuStatus["MoveSpeed"] = 2.0f;
        DubuStatus["RunSpeed"] = 6.0f;
        DubuStatus["JumpForce"] = 1500;
        // 장탄수
        DubuStatus["Cartridge"] = 50f;
        DubuStatus["ReLoadTime"] = 1.7f;

        DubuStatus["Attack"] = 15f;
        DubuStatus["AtttackSpeed"] = 0.25f;

        DubuStatus["StrongAttack"] = 30f;
        DubuStatus["StrongAttack_CoolTime"] = 5.0f;
        DubuStatus["StongAttackReady"] = 0.23f;//수정X
        DubuStatus["StongAttackTime"] = 0.43f;//수정X
        DubuStatus["StongAttackEnd"] = 0.86f;//수정X

        DubuStatus["SpecialAttack"] = 100.0f;
        DubuStatus["SpecialAttack_CoolTime"] = 25.0f;
        DubuStatus["SpecialAttackReady"] = 0.86f;//수정X
        DubuStatus["SpecialAttackTime"] = 0.56f;//수정X
        DubuStatus["SpecialAttackEnd"] = 1.43f;//수정X
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
