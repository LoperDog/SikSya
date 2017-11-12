using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangsuAnimation : AnimationSuper
{
    TangsuCharacter CharacterScript;

    public override void SetChar(CharacterSuper CharScript)
    {
        base.SetChar(CharScript);
        CharacterScript = (TangsuCharacter)CharScript;
    }
    public override void PlayAttack()
    {
        m_Anim.SetBool("Attack", m_Char_State.GetIsAttack());
    }
    //일반공격
    public void Attack1_Start()
    {

    }
    public void Attack1_End()
    {

    }
    public void Attack2_Start()
    {

    }
    public void Attack2_End()
    {

    }
    public void Attack3_Start()
    {

    }
    public void Attack3_End()
    {

    }
    //강공격
    public void SetStrongAttackReady()
    {

    }
    public void SetStrongAttackDash()
    {

    }
    public void SetStrongAttackEnd()
    {

    }
    //특수기
    public void SetSpecialAttackReady()
    {

    }
    public void SetSpecialAttack_ing()
    {

    }
    public void SetSpecialAttackEnd()
    {

    }
}
