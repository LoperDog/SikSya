using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinClass : MonoBehaviour
{
    public CharacterSuper thisCharacterScript;
    public CharacterMgr thisMgr;
    public Coroutine StrongCorutin;
    public Coroutine SpecialCorutin;
    static public ConfigClass config;

    // 코루틴으로 사용할 컴포넌트에 스크립트를 설정한다.
    public virtual void SetCharacterScript(CharacterSuper CharacterClass)
    {
        thisCharacterScript = CharacterClass;
    }
    public virtual void SetMgr(CharacterMgr mg)
    {
        thisMgr = mg;
    }

    // 외부에서 실행시키는 기본공격
    public virtual void StartAttackSetting()
    {
        StartCoroutine(SetAttackState());
    }
    public virtual void StartStrongAttckSetting()
    {
        StrongCorutin = StartCoroutine(SetStrongAttack());
        StartCoroutine(StartStrongCoolTime());
    }
    public virtual void StartSpecialAttackSetting()
    {
        SpecialCorutin =  StartCoroutine(SetSpecialAttack());
        StartCoroutine(StartSpecialCoolTime());
    }
    public virtual void StartReLoad()
    {
        StartCoroutine(SetReLoad());
    }
    public virtual void StartTaunt1()
    {
        StartCoroutine(SetTaunt1());
    }
    public virtual void StartTaunt2()
    {
        StartCoroutine(SetTaunt2());
    }
    public virtual void StartRespawn()
    {
        StartCoroutine(SetRespawn());
    }
    public void StartFalling()
    {
        StartCoroutine(SetFalling());
    }
    public virtual void StartBuffSetting(float time, CharacterSuper.ItemCode code, float value)
    {
        thisMgr.SetBuff(code);
        StartCoroutine(EndBuffItem(time, code, value));
    }
    // 무적
    public virtual void StartOverPower()
    {
        StartCoroutine(SetOverPower());
    }
    public IEnumerator SetOverPower()
    {
        yield return new WaitForSeconds(5.0f);
        thisMgr.EndOverPower();
    }
    public virtual void StartDead()
    {
        StartCoroutine(SetDead());
    }
    public virtual IEnumerator SetDead()
    {
        yield return new WaitForSeconds(2.0f);
        thisMgr.SetDead();
    }
    public virtual IEnumerator SetAttackState()
    {
        yield return new WaitForSeconds(thisCharacterScript.CurrentAttack);
        thisCharacterScript.Is_Attack = false;
    }
    public virtual IEnumerator SetStrongAttack()
    {
        yield return new WaitForSeconds(thisCharacterScript.CurrentStrongAttack);
        thisCharacterScript.Is_StrongAttack = false;
    }
    public virtual IEnumerator SetSpecialAttack()
    {
        yield return new WaitForSeconds(thisCharacterScript.CurrentSpecialAttack);
        thisCharacterScript.Is_SpecialAttack = false;
    }
    public virtual IEnumerator SetReLoad()
    {
        yield return new WaitForSeconds(thisCharacterScript.m_TimeReload);
        thisCharacterScript.SetBullet(thisCharacterScript.m_Max_Bullet);
        thisCharacterScript.Is_ReLoad = false;
    }
    public virtual IEnumerator SetTaunt1()
    {
        yield return new WaitForSeconds(thisCharacterScript.m_Time_Taunt);
        thisCharacterScript.Is_Taunt1 = false;
    }
    public virtual IEnumerator SetTaunt2()
    {
        yield return new WaitForSeconds(thisCharacterScript.m_Time_Taunt);
        thisCharacterScript.Is_Taunt2 = false;
    }
    public IEnumerator SetFalling()
    {
        thisCharacterScript.CanControll = false;
        yield return new WaitForSeconds(3.0f);
        thisCharacterScript.CanControll = true;
    }
    // 아직은 작업 중.
    public virtual IEnumerator SetWhileBuff(float time)
    {
        yield return new WaitForSeconds(time);
    }

    // 추후 공격력 버프나 뭔가를 만들때 쓰자구.
    public virtual IEnumerator EndBuffItem(float time, CharacterSuper.ItemCode Code, float value)
    {
        yield return new WaitForSeconds(time);
        thisMgr.EndBuff(Code);
    }

    public virtual IEnumerator StartStrongCoolTime()
    {
        while (thisMgr.StrongAttackCoolTime >= 0.0)
        {
            yield return new WaitForSeconds(0.1f);
            thisMgr.StrongAttackCoolTime -= Time.deltaTime;
        }
        thisMgr.StrongAttackCoolTime = 0.0f;
    }
    public virtual IEnumerator StartSpecialCoolTime()
    {
        while (thisMgr.SpecialAttackCoolTime >= 0.0)
        {
            yield return new WaitForSeconds(0.1f);
            thisMgr.SpecialAttackCoolTime -= Time.deltaTime;
        }
        thisMgr.SpecialAttackCoolTime = 0.0f;
    }
    public virtual IEnumerator SetRespawn()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        yield return new WaitForSeconds(5.0f);
        thisMgr.StartRespawn();
    }
}