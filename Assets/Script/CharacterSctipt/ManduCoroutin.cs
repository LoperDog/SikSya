﻿using System.Collections;
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
    public override IEnumerator SetStrongAttack()
    {
        if (thisCharacterScript.Is_Dead) yield break;
        if (config == null)
        {
            config = new ConfigClass();
        }
        StartCoroutine(SetStrongAttackShoot());
        yield return new WaitForSeconds(thisCharacterScript.CurrentStrongAttack);
    }
    public IEnumerator SetStrongAttackShoot()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        ManduChar.StrongAttackShootStart();
        ManduChar.StrongAttackReady();
        yield return new WaitForSeconds(config.StatusConfigs["Mandu"]["StongAttackTime"]);
        ManduChar.StrongAttackEnd();
        thisMgr.m_StrongAttack.ReSetAttack();
        ManduChar.StrongAttackShootEnd();
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
        if (thisCharacterScript.Is_Dead) yield break;
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;//제어불가
        ManduChar.SpecialAttackReady();//애니메이션 실행
        yield return new WaitForSeconds(config.StatusConfigs["Mandu"]["SpecialAttackReady"]);
        StartCoroutine(SetSpecialAttackEnd());//다음 코루틴 실행
    }
    public IEnumerator SetSpecialAttackEnd()
    {
        if (thisCharacterScript.Is_Dead)//죽으면
        {
            ManduChar.SpecialAttackEnd();//애니메이션 실행하고 종료
            yield break;
        }
        if (config == null)
        {
            config = new ConfigClass();
        }
        ManduChar.SpecialAttack_ing();//공격판정,이팩트
        yield return new WaitForSeconds(config.StatusConfigs["Mandu"]["SpecialAttackTime"]);
        ManduChar.SpecialAttackEnd();
        thisCharacterScript.CanControll = true;
        thisMgr.m_SpecialAttack.ReSetAttack();
        thisCharacterScript.Is_SpecialAttack = false;
    }
    public override IEnumerator SetTaunt1()
    {
        if (thisCharacterScript.Is_Dead) yield break;
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
        if (thisCharacterScript.Is_Dead) yield break;
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