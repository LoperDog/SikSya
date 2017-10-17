using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManduCoroutin : CoroutinClass
{
    public ManduCharacter ManduChar;

    public override void SetCharacterScript(CharacterSuper CharacterClass)
    {
        base.SetCharacterScript(CharacterClass);
        ManduChar = (ManduCharacter)CharacterClass;
    }

     //강공격
    public override void StartStrongAttckSetting()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.StrongAttackCoolTime = config.StatusConfigs["Mandu"]["StrongAttack_CoolTime"];
        base.StartStrongAttckSetting();
    }
     //특수기
    public override void StartSpecialAttackSetting()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.SpecialAttackCoolTime = config.StatusConfigs["Mandu"]["SpecialAttack_CoolTime"];
        base.StartSpecialAttackSetting();
    }
    public override IEnumerator SetSpecialAttack()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;
        ManduChar.SpecialAttackReady();
        yield return new WaitForSeconds(config.StatusConfigs["Mandu"]["SpecialAttackTime"]);
        ManduChar.SpecialAttackEnd();
        thisCharacterScript.CanControll = true;
        thisCharacterScript.IsSpecialAttack = false;
    }
    //도발
    public override IEnumerator SetTaunt1()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;
        thisCharacterScript.Is_Taunt1 = true;
        yield return new WaitForSeconds(config.StatusConfigs["Mandu"]["Taunt1"]);
        thisCharacterScript.CanControll = true;
        thisCharacterScript.Is_Taunt1 = false;
    }
    public override IEnumerator SetTaunt2()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;
        thisCharacterScript.Is_Taunt2 = true;
        yield return new WaitForSeconds(config.StatusConfigs["Mandu"]["Taunt2"]);
        thisCharacterScript.CanControll = true;
        thisCharacterScript.Is_Taunt2 = false;
    }
}