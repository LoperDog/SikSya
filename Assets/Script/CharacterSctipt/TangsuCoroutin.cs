using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangsuCoroutin : CoroutinClass
{
    public TangsuCharacter TangsuChar;
    public bool TangsuDoingAttack = false;
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
        if (TangsuDoingAttack) yield break;
        thisCharacterScript.CanControll = false;//제어불가
        thisCharacterScript.Is_Attack = true;//공격시작
        TangsuDoingAttack = true;
        TangsuChar.Attack1();//1타 이팩트,판정을 킨다
        StartCoroutine(Attack1ColliderEnd()); //타격 판단을 끝낸다.
        StartCoroutine(Attack1IsNextAttack());//1타 끝내러 간다
        yield break;
    }
    // 1타의 타격판단을 껐다.
    public IEnumerator Attack1ColliderEnd()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        yield return new WaitForSeconds(config.StatusConfigs["Tangsu"]["Atttack1_Start"]);//0.33
        thisMgr.m_StrongAttack.ReSetAttack();//판정을 끈다
    }
    // 사용자가 어떻게 하고싶은가
    public IEnumerator Attack1IsNextAttack()
    {
        yield return new WaitForSeconds(0.16f); //여기까지 의 값은 무시한다.
        TangsuChar.ComboAttack = false;
        thisCharacterScript.CanControll = true;//제어가능
        yield return new WaitForSeconds(0.4f); //여기까지 의 값은 무시한다.
        thisCharacterScript.Is_Attack = false;//1타 공격 끝
        // 다음공격을 하고싶은것인가?
        if (TangsuChar.ComboAttack)
        {
            thisMgr._networkView.RPC("TempTangsuAttack2",RPCMode.AllBuffered,null);
        }
        else
        {
            TangsuDoingAttack = false;
        }
    }
    public void StartAttack2()
    {
        StartCoroutine(Attack2Start());//2타공격 시작
    }
    public void StartAttack3()
    {
        StartCoroutine(Attack3Start());//3타공격 시작
    }
    public IEnumerator Attack2Start()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;//제어불가
        thisCharacterScript.Is_Attack2 = true;//2타공격 시작
        TangsuChar.Attack2();//2타 이팩트,판정을 킨다.
        StartCoroutine(Attack2Collider());
        StartCoroutine(Attack2IsNextAttack());
        yield break;
    }
    public IEnumerator Attack2Collider()
    {
        yield return new WaitForSeconds(0.33f);
        thisMgr.m_StrongAttack.ReSetAttack();//판정을 끈다
    }
    public IEnumerator Attack2IsNextAttack()
    {
        yield return new WaitForSeconds(0.166f); //여기까지 의 값은 무시한다.
        TangsuChar.ComboAttack = false;
        thisCharacterScript.CanControll = true;//제어가능
        yield return new WaitForSeconds(0.5f); //여기까지 의 값은 무시한다.
        thisCharacterScript.Is_Attack2 = false;//2타 공격 끝
        // 다음공격을 하고싶은것인가?
        if (TangsuChar.ComboAttack)
        {
            thisMgr._networkView.RPC("TempTangsuAttack2", RPCMode.AllBuffered, null);
        }
        else
        {
            TangsuDoingAttack = false;
        }
    }
    public IEnumerator Attack3Start()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;//제어불가
        thisCharacterScript.Is_Attack3 = true;//3타공격 시작
        TangsuChar.Attack3();//3타 이팩트,판정을 킨다
        yield return new WaitForSeconds(config.StatusConfigs ["Tangsu"] ["Atttack3_Start"]);//3타 시작
        StartCoroutine(Attack3End());
    }
    public IEnumerator Attack3End()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.m_StrongAttack.ReSetAttack();//판정을 끈다
        thisCharacterScript.CanControll = true;//제어가능
        yield return new WaitForSeconds(config.StatusConfigs ["Tangsu"] ["Atttack3_End"]);//3타 끝
        thisCharacterScript.Is_Attack3 = false;//3타 공격 끝
        TangsuDoingAttack = false;
    }
    //구르기
    public override void StartStrongAttckSetting()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.StrongAttackCoolTime = config.StatusConfigs["Tangsu"]["StrongAttack_CoolTime"];
        base.StartStrongAttckSetting();
    }
    public override IEnumerator SetStrongAttack()
    {
        if (thisCharacterScript.Is_Dead) yield break;
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;
        TangsuChar.StrongAttackReady();
        yield return new WaitForSeconds(config.StatusConfigs["Tangsu"]["Tumbling_Time"]);
        thisCharacterScript.CanControll = true;
        TangsuChar.StrongAttackEnd();
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
        TangsuChar.SpecialAttackEnd();//애니메이션,판정을 끈다
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
    }
}
