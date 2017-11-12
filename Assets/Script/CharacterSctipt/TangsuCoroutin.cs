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
        Debug.Log("연타중 들어오면 안됨");
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
        Debug.Log("2타시작");
        thisCharacterScript.CanControll = false;//제어불가
        thisCharacterScript.Is_Attack2 = true;//2타공격 시작
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
        Debug.Log("2타 끝");
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
        Debug.Log("3타시작");
        thisCharacterScript.CanControll = false;//제어불가
        thisCharacterScript.Is_Attack3 = true;//3타공격 시작
        yield return new WaitForSeconds(thisMgr.StrongAttackCoolTime = config.StatusConfigs ["Tangsu"] ["Atttack3_Start"]);//3타 시작
        StartCoroutine(Attack3End());
    }
    public IEnumerator Attack3End()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        Debug.Log("3타 끝");
        yield return new WaitForSeconds(thisMgr.StrongAttackCoolTime = config.StatusConfigs ["Tangsu"] ["Atttack3_End"]);//3타 끝
        thisCharacterScript.CanControll = true;//제어가능
        thisCharacterScript.Is_Attack3 = false;//3타 공격 끝
    }
}
