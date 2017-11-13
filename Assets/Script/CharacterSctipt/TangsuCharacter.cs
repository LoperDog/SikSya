using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangsuCharacter : CharacterSuper
{
    public TangsuAnimation CharAnim;

    public bool ComboAttack = false;

    override public void Attack()
    {
        if (!Is_Attack && !Is_Jump)
        {
            coroutine.StartAttackSetting();
        }
    }
    //일반공격 시작
    public void Attack1()
    {
        Transform temp = Instantiate(effect[0], Player_tr.position, Player_tr.rotation);
        temp.SetParent(Player_tr);
        temp.GetComponent<DestroyMe1>().SetTargetPosition(Player_tr.position);
    }
    public void Attack2()
    {
        Transform temp = Instantiate(effect[1], Player_tr.position, Player_tr.rotation);
        temp.SetParent(Player_tr);
        temp.GetComponent<DestroyMe1>().SetTargetPosition(Player_tr.position);
    }
    public void Attack3()
    {
        Transform temp = Instantiate(effect[2], Player_tr.position, Player_tr.rotation);
        temp.SetParent(Player_tr);
        temp.GetComponent<DestroyMe1>().SetTargetPosition(Player_tr.position);
    }
    //강공격 시작
    public override void StrongAttack()
    {

    }
    public void StrongAttackReady()
    {

    }
    public void StrongAttackEnd()
    {

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
    public void SpecialAttackEnd()
    {
        CharAnim.SetSpecialAttackEnd();
    }
    public override void SetAnimator(AnimationSuper anim)
    {
        base.SetAnimator(anim);
        CharAnim = (TangsuAnimation)anim;
    }
}