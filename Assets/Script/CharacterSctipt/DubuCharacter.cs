using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DubuCharacter : CharacterSuper
{
    public DubuAnimation CharAnim;

    public bool AttackIsLeft = false;

    override public void Attack()
    { 
        // 공격중이 아닌데 공격 이 시작된다면 - 공격 가능
        if (!Is_Attack && !Is_ReLoad && m_Current_Bullet > 0)
        {
            m_Current_Bullet--;
            Is_Attack = true;
            // 왼쪽공격이라면
            if (AttackIsLeft)
            {

            }
            else
            {

            }
            ShotBullet();
            AttackIsLeft = !AttackIsLeft;
            //기본 사속을 조금씩 줄인다.
            if((m_CurrentAttack - 0.005f) >= 0.0f)
            {
                m_CurrentAttack -= 0.005f;
            }
        }
        // 공격이 시작될수 있는데 총알이 없다면 - 공격 불가 상태
        else if (!Is_Attack && !Is_ReLoad && m_Current_Bullet == 0)
        {
            ReLoad();
        }
        else
        {
            //m_CurrentAttack = 0.0f;
        }
    }
    // 강공격을 시작한다.
    public override void StrongAttack()
    {
        if (!Is_StrongAttack && !Is_SpecialAttack && !Is_Attack && Is_Ground && !Is_Taunt1 && !Is_Taunt2 /*&& mgr.StrongAttackCoolTime == 0*/)
        {
            coroutine.StartStrongAttckSetting();
            Transform temp = Instantiate(effect[5], Player_tr.position, Player_tr.rotation);
            temp.SetParent(Player_tr);
            temp.GetComponent<DestroyMe1>().Target = effectPosition[1];
        }
    }
    public void StrongAttackReady()
    {
        CharAnim.SetStrongAttackReady();
    }
    // 강공격 대미지가 들어가는 부분.
    // 이팩트 생성, 애니매이션 재생. 
    public void StrongAttackDash()
    {
        Transform temp = Instantiate(effect[6], Player_tr.position, Player_tr.rotation);
        temp.SetParent(Player_tr);
        temp.GetComponent<DestroyMe1>().Target = effectPosition[1];
        mgr.RoundAttack[0].SetActive(true);
        CharAnim.SetStrongAttackDash();
    }
    // 강공격이 끝나는 부분.
    public void StrongAttackEnd()
    {
        CharAnim.SetStrongAttackEnd();
    }
    //특수기 시작
    public override void SpecialAttack()
    {
        if (!Is_StrongAttack && !Is_SpecialAttack && !Is_Attack && Is_Ground && !Is_Taunt1 && !Is_Taunt2 && mgr.SpecialAttackCoolTime == 0)
        {
            coroutine.StartSpecialAttackSetting();
        }
    }
    // 특수기가 시작할때 시간을 재기 시작한다.
    public void SpecialAttackReady()
    {
        CharAnim.SetSpecialAttackReady();
        Transform temp = Instantiate(effect[2],
            Player_tr.position,
            Player_tr.rotation);
        temp.SetParent(Player_tr);
    }
    // 특수기가 한창일때
    public void SpecialAttackDash()
    {
        Transform temp = Instantiate(effect[3],
            Player_tr.position,
            Player_tr.rotation);
        temp.SetParent(Player_tr);
        mgr.RoundAttack[1].SetActive(true);
    }
    // 끝에서 처리할것.
    public void SpecialAttackEnd()
    {
        Transform temp = Instantiate(effect[4],
            Player_tr.position,
            Player_tr.rotation);
        temp.SetParent(Player_tr);
        CharAnim.SetSpecialAttackEnd();
    }
    public override void UpAttack()
    {
        base.UpAttack();
        if (config == null)
        {
            config = new ConfigClass();
        }
        CurrentAttack = config.StatusConfigs["Dubu"]["AtttackSpeed"];
    }
    public override void ReLoad()
    {
        base.ReLoad();
        if(config == null)
        {
            config = new ConfigClass();
        }
        CurrentAttack = config.StatusConfigs["Dubu"]["AtttackSpeed"];
    }
    // 애니매이터 세팅을 바꿔준다. 여기에 온다면 분명 두부 애니매이션 일테니까
    public override void SetAnimator(AnimationSuper anim)
    {
        base.SetAnimator(anim);
        CharAnim = (DubuAnimation)anim;
    }
}
