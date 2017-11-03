using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DubuCoroutin : CoroutinClass
{
    public DubuCharacter DubuChar;

    public override void SetCharacterScript(CharacterSuper CharacterClass)
    {
        base.SetCharacterScript(CharacterClass);
        DubuChar = (DubuCharacter)CharacterClass;
    }

    //강공격
    public override void StartStrongAttckSetting()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.StrongAttackCoolTime = config.StatusConfigs["Dubu"]["StrongAttack_CoolTime"];
        base.StartStrongAttckSetting();
    }
    public override IEnumerator SetStrongAttack()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        StartCoroutine(SetStrongAttackDash());
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StrongAttack_CoolTime"]);
        thisCharacterScript.Is_StrongAttack = false;
    }
    public IEnumerator SetStrongAttackDash()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;
        DubuChar.StrongAttackReady();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StongAttackReady"]);
        StartCoroutine(SetStrongAttackEnd());
    }
    public IEnumerator SetStrongAttackEnd()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.StrongAttackDash();
        DubuChar.StrongAttackEnd();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StongAttackEnd"]);
        thisCharacterScript.CanControll = true;
        thisMgr.m_StrongAttack.ReSetAttack();
    }
    //특수기
    public override void StartSpecialAttackSetting()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.SpecialAttackCoolTime = config.StatusConfigs["Dubu"]["SpecialAttack_CoolTime"];
        base.StartSpecialAttackSetting();
    }
    public override IEnumerator SetSpecialAttack()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;
        StartCoroutine(SetSpecialSpecialAttakReady());
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttack_CoolTime"]);
        thisCharacterScript.Is_SpecialAttack = false;
    }
    public IEnumerator SetSpecialSpecialAttakReady()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.SpecialAttackReady();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackReady"]);
        StartCoroutine(SetSpecialAttackDash());
    }
    public IEnumerator SetSpecialAttackDash()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.SpecialAttackDash();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackTime"]);
        StartCoroutine(SetSpecialAttackEnd());
    }
    public IEnumerator SetSpecialAttackEnd()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.m_SpecialAttack.ReSetAttack();
        DubuChar.SpecialAttackEnd();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackEnd"]);
        thisCharacterScript.CanControll = true;
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
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["Taunt1"]);
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
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["Taunt2"]);
        thisCharacterScript.CanControll = true;
        thisCharacterScript.Is_Taunt2 = false;
    }
}