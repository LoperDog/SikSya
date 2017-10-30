using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManduCharacter : CharacterSuper
{
    public ManduAnimation CharAnim;

    override public void Attack()
    {
        // 공격중이 아닌데 공격 이 시작된다면 - 공격 가능
        if (!Is_Attack && !Is_ReLoad && m_Current_Bullet > 0)
        {
            m_Current_Bullet--;
            Is_Attack = true;
            ShotBullet();
        }
        else if (!Is_Attack && !Is_ReLoad && m_Current_Bullet == 0)
        {
            ReLoad();
        }
        else
        {

        }
    }
    public override void ReLoad()
    {
        base.ReLoad();
        if (config == null)
        {
            config = new ConfigClass();
        }
        CurrentAttack = config.StatusConfigs["Mandu"]["AtttackSpeed"];
    }
    //강공격 시작
    public override void StrongAttack()
    {
        if (!Is_StrongAttack && !Is_SpecialAttack && !Is_Attack && !Is_ReLoad && Is_Ground && m_Current_Bullet > 1 && !Is_Taunt1 && !Is_Taunt2 && mgr.StrongAttackCoolTime == 0)
        {
            coroutine.StartStrongAttckSetting();
            Transform temp = Instantiate(effect[3], FirePoint.GetComponent<Transform>().position, Player_tr.rotation);
            temp.SetParent(Player_tr);
            temp.GetComponent<DestroyMe1>().Target = effectPosition[1];
            mgr.RoundAttack[0].SetActive(true);
            m_Current_Bullet -= 2;
        }
        else if (m_Current_Bullet <= 0)
        {
            ReLoad();
        }
    }
    public void StrongAttackReady()
    {
        CharAnim.SetStrongAttackReady();
    }
    public void StrongAttackEnd()
    {
        CharAnim.SetStrongAttackEnd();
    }
    public void StrongAttackShootStart()
    {
        mgr.RoundAttack[0].SetActive(true);
    }
    public void StrongAttackShootEnd()
    {

    }
    //특수기 시작
    public override void SpecialAttack()
    {
        if (!Is_StrongAttack && !Is_SpecialAttack && !Is_Attack && Is_Ground && !Is_Taunt1 && !Is_Taunt2 /*&& mgr.SpecialAttackCoolTime == 0*/)
        {
            coroutine.StartSpecialAttackSetting();
        }
    }
    public void SpecialAttackReady()
    {
        CharAnim.SetSpecialAttackReady();
    }
    public void SpecialAttack_ing()
    {
        Transform temp = Instantiate(effect[4], Player_tr.position, Player_tr.rotation);
        temp.SetParent(Player_tr);
        temp.GetComponent<DestroyMe1>().Target = effectPosition[0];
        mgr.RoundAttack[0].SetActive(true);
    }
    public void SpecialAttackEnd()
    {
        CharAnim.SetSpecialAttackEnd();
    }
    public override void SetAnimator(AnimationSuper anim)
    {
        base.SetAnimator(anim);
        CharAnim = (ManduAnimation)anim;
    }
}
