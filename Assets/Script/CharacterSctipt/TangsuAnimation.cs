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
        m_Anim.SetBool("Attack2", m_Char_State.GetIsAttack2());
        m_Anim.SetBool("Attack3", m_Char_State.GetIsAttack3());
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
        m_Anim.SetBool("Is_SpecialAttackReady", true);
    }
    public void SetSpecialAttackEnd()
    {
        m_Anim.SetBool("Is_SpecialAttackReady", false);
    }
}
