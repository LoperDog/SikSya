using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangsuCoroutin : CoroutinClass
{
    public TangsuCharacter TangsuChar;

    public override void SetCharacterScript(CharacterSuper CharacterClass)
    {
        base.SetCharacterScript(CharacterClass);
        TangsuChar = (TangsuCharacter)CharacterClass;
    }

    //일반공격
    public override IEnumerator SetAttackState()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;//제어불가
        thisCharacterScript.Is_Attack = true;//공격시작
        TangsuChar.Attack1();//1타 이팩트 킨다.
        yield return new WaitForSeconds(thisMgr.StrongAttackCoolTime = config.StatusConfigs ["Tangsu"] ["Atttack1_Start"]);//1타 시작
        StartCoroutine(Attack1End());//1타 끝내러 간다
    }
    public IEnumerator Attack1End()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        if(Input.GetMouseButton(0))
        {
            thisCharacterScript.Is_Attack = false;//1타 공격 끝
            thisCharacterScript.CanControll = true;//제어가능
            StartCoroutine(Attack2Start());//2타공격 시작
            yield break;
        }
        yield return new WaitForSeconds(thisMgr.StrongAttackCoolTime = config.StatusConfigs ["Tangsu"] ["Atttack1_End"]);//1타 끝
        thisCharacterScript.CanControll = true;//제어가능
        thisCharacterScript.Is_Attack = false;//1타 공격 끝
    }
    public IEnumerator Attack2Start()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;//제어불가
        thisCharacterScript.Is_Attack2 = true;//2타공격 시작
        TangsuChar.Attack2();//2타 이팩트 킨다.
        yield return new WaitForSeconds(thisMgr.StrongAttackCoolTime = config.StatusConfigs ["Tangsu"] ["Atttack2_Start"]);//2타 시작
        StartCoroutine(Attack2End());
    }
    public IEnumerator Attack2End()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        if (Input.GetMouseButton(0))
        {
            thisCharacterScript.Is_Attack2 = false;//2타 공격 끝
            thisCharacterScript.CanControll = true;//제어가능
            StartCoroutine(Attack3Start());//3타공격 시작
            yield break;
        }
        yield return new WaitForSeconds(thisMgr.StrongAttackCoolTime = config.StatusConfigs ["Tangsu"] ["Atttack2_End"]);//2타 끝
        thisCharacterScript.CanControll = true;//제어가능
        thisCharacterScript.Is_Attack2 = false;//2타 공격 끝
    }
    public IEnumerator Attack3Start()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;//제어불가
        thisCharacterScript.Is_Attack3 = true;//3타공격 시작
        TangsuChar.Attack3();//3타 이팩트 킨다.
        yield return new WaitForSeconds(thisMgr.StrongAttackCoolTime = config.StatusConfigs ["Tangsu"] ["Atttack3_Start"]);//3타 시작
        StartCoroutine(Attack3End());
    }
    public IEnumerator Attack3End()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        yield return new WaitForSeconds(thisMgr.StrongAttackCoolTime = config.StatusConfigs ["Tangsu"] ["Atttack3_End"]);//3타 끝
        thisCharacterScript.CanControll = true;//제어가능
        thisCharacterScript.Is_Attack3 = false;//3타 공격 끝
    }
    //특수기
    public override void StartSpecialAttackSetting()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.SpecialAttackCoolTime = config.StatusConfigs ["Tangsu"] ["SpecialAttack_CoolTime"];
        base.StartSpecialAttackSetting();
    }
    public override IEnumerator SetSpecialAttack()
    {
        if (thisCharacterScript.Is_Dead) yield break;
        if (config == null)
        {
            config = new ConfigClass();
        }
        Debug.Log("특수기 시작된다");
        thisCharacterScript.CanControll = false;//제어불가
        TangsuChar.SpecialAttackReady();
        yield return new WaitForSeconds(config.StatusConfigs ["Tangsu"] ["SpecialAttack_Ready"]);//공격 순간
        TangsuChar.SpecialAttack_ing();//이팩트,판정을 여기서 켠다
        StartCoroutine(SpecialAttack_Start());
    }
    public IEnumerator SpecialAttack_Start()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        yield return new WaitForSeconds(config.StatusConfigs ["Tangsu"] ["SpecialAttack_End"]);//끝나는 시간
        TangsuChar.SpecialAttackEnd();//애니메이션만 끝낸다
        thisCharacterScript.CanControll = true;//제어가능
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
        yield return new WaitForSeconds(config.StatusConfigs["Tangsu"]["Taunt1"]);
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
        yield return new WaitForSeconds(config.StatusConfigs["Tangsu"]["Taunt2"]);
        thisCharacterScript.CanControll = true;
        thisCharacterScript.Is_Taunt2 = false;
        Debug.Log("특수기 꺼진다");
    }
}
