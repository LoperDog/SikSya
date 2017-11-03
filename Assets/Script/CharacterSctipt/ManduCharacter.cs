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

            Transform temp = Instantiate(effect[0], Player_tr.position, Player_tr.rotation);
            temp.SetParent(Player_tr);
            temp.GetComponent<DestroyMe1>().SetTargetPosition(effectPosition[0].position);
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
        coroutine.StartStrongAttckSetting();
        Transform temp = Instantiate(effect[3], FirePoint.GetComponent<Transform>().position, Player_tr.rotation);
        temp.SetParent(Player_tr);
        temp.GetComponent<DestroyMe1>().SetTargetPosition(effectPosition[1].position);
        mgr.RoundAttack[0].SetActive(true);
        m_Current_Bullet -= 2;
        if (m_Current_Bullet <= 0)
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

    }
    public void StrongAttackShootEnd()
    {

    }
    //특수기 시작
    public override void SpecialAttack()
    {
        coroutine.StartSpecialAttackSetting();
    }
    public void SpecialAttackReady()
    {
        CharAnim.SetSpecialAttackReady();
    }
    public void SpecialAttack_ing()
    {
        Transform temp = Instantiate(effect[4], Player_tr.position, Player_tr.rotation);
        temp.SetParent(Player_tr);
        temp.GetComponent<DestroyMe1>().SetTargetPosition(effectPosition[0].position);
        mgr.RoundAttack[1].SetActive(true);
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
