using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangsuCharacter : CharacterSuper
{
    public TangsuAnimation CharAnim;

    public bool ComboAttack;
    public TangsuCoroutin TangsuCorutine;

    public override void SetCoroutine(CoroutinClass co)
    {
        base.SetCoroutine(co);
        TangsuCorutine = (TangsuCoroutin)co;
    }
    override public void Attack()
    {
        if (!Is_Attack && !Is_Jump)
        {
            coroutine.StartAttackSetting();
        }
    }
    //구르기
    public override void StrongAttack()
    {
        coroutine.StartStrongAttckSetting();
    }
    //일반공격 시작
    public void Attack1()
    {
        Transform temp = Instantiate(effect[0], Player_tr.position, Player_tr.rotation);
        temp.SetParent(Player_tr);
        temp.GetComponent<DestroyMe1>().SetTargetPosition(Player_tr.position);
        mgr.RoundAttack[0].SetActive(true);
    }
    public void Attack2()
    {
        Transform temp = Instantiate(effect[1], Player_tr.position, Player_tr.rotation);
        temp.SetParent(Player_tr);
        temp.GetComponent<DestroyMe1>().SetTargetPosition(Player_tr.position);
        mgr.RoundAttack[0].SetActive(true);
    }
    public void Attack3()
    {
        Transform temp = Instantiate(effect[2], Player_tr.position, Player_tr.rotation);
        temp.SetParent(Player_tr);
        temp.GetComponent<DestroyMe1>().SetTargetPosition(Player_tr.position);
        mgr.RoundAttack[0].SetActive(true);
    }
    public override void CharacterUpdate()
    {
        if (TangsuCorutine.TangsuDoingAttack)
        {
            //Player_rb.velocity = new Vector3(0.0f, Player_rb.velocity.y, 0.0f);
            mgr.keyh = 0.0f;
            mgr.keyv = 0.0f;
        }
        base.CharacterUpdate();
        if (Input.GetMouseButton(0))
        {
            ComboAttack = true;
        }
    }
    //강공격 시작
    public void StrongAttackReady()
    {
        CharAnim.SetStrongAttackReady();
    }
    public void StrongAttackEnd()
    {
        CharAnim.SetStrongAttackEnd();
    }
    //특수기 시작
    public override void SpecialAttack()
    {
        coroutine.StartSpecialAttackSetting();
    }
    public void SpecialAttackReady()
    {
        CharAnim.SetSpecialAttackReady();
        Transform temp = Instantiate(effect[3], Player_tr.position, Player_tr.rotation);
        temp.SetParent(Player_tr);
        temp.GetComponent<DestroyMe1>().SetTargetPosition(Player_tr.position);
    }
    public void SpecialAttack_ing()
    {
        Transform temp = Instantiate(effect[4], Player_tr.position, Player_tr.rotation);
        temp.SetParent(Player_tr);
        temp.GetComponent<DestroyMe1>().SetTargetPosition(Player_tr.position);
        mgr.RoundAttack[1].SetActive(true);
    }
    public void SpecialAttackEnd()
    {
        CharAnim.SetSpecialAttackEnd();
        mgr.m_SpecialAttack.ReSetAttack();
    }
    public override void SetAnimator(AnimationSuper anim)
    {
        base.SetAnimator(anim);
        CharAnim = (TangsuAnimation)anim;
    }
}