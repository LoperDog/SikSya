using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangsuCharacter : CharacterSuper
{
    public TangsuAnimation CharAnim;

    public bool ComboAttack = false;

    override public void Attack()
    {
        if(!Is_Attack)
        {
            coroutine.StartAttackSetting();
        }
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

    }
    public void SpecialAttackReady()
    {

    }
    public void SpecialAttack_ing()
    {
        
    }
    public void SpecialAttackEnd()
    {

    }
    public override void SetAnimator(AnimationSuper anim)
    {
        base.SetAnimator(anim);
        CharAnim = (TangsuAnimation)anim;
    }
}