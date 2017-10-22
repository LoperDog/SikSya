using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManduCharacter : CharacterSuper
{
    public ManduAnimation CharAnim;

    override public void Attack()
    {
        // 공격중이 아닌데 공격 이 시작된다면 - 공격 가능
        if (!IsAttack && !IsReLoad && m_Current_Bullet > 0)
        {
            m_Current_Bullet--;
            IsAttack = true;
            ShotBullet();
        }
        else if (!IsAttack && !IsReLoad && m_Current_Bullet == 0)
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
        if (!IsStrongAttack && GetIsGroud() && mgr.StrongAttackCoolTime == 0)//강공격이 아니고 땅에 있고 쿨타임이 0초일때
        {
            coroutine.StartStrongAttckSetting();
            Transform temp = Instantiate(effect[3], effectPosition[1].position, Player_tr.rotation);//이팩트 생성
            temp.GetComponent<DestroyMe1>().Target = effectPosition[0];//0.3초후 제거
            temp.SetParent(Player_tr);//위치잡아줌
            //mgr.RoundAttack[0].SetActive(true);
        }
    }
    //특수기 시작
    public override void SpecialAttack()
    {
        if (!IsSpecialAttack && GetIsGroud() && !IsAttack)
        {
            coroutine.StartSpecialAttackSetting();
        }
    }
    public void SpecialAttackReady()
    {
        CharAnim.SetSpecialAttackReady();
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
