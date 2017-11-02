using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManduAnimation : AnimationSuper
{
    ManduCharacter CharacterScript;

    public override void SetChar(CharacterSuper CharScript)
    {
        base.SetChar(CharScript);
        CharacterScript = (ManduCharacter)CharScript;
    }
    //공격
    public override void PlayAttack()
    {
        m_Anim.SetBool("Attack", m_Char_State.GetIsAttack());
    }
    //강공격
    public void SetStrongAttackReady()
    {
        m_Anim.SetBool("Is_StrongAttackReady", true);
    }
    public void SetStrongAttackDash()
    {

    }
    public void SetStrongAttackEnd()
    {
        m_Anim.SetBool("Is_StrongAttackReady", false);
    }
    //특수기
    public void SetSpecialAttackReady()
    {
        m_Anim.SetBool("Is_SpecialAttackReady", true);
    }
    public void SetSpecialAttack_ing()
    {

    }
    public void SetSpecialAttackEnd()
    {
        m_Anim.SetBool("Is_SpecialAttackReady", false);
    }
}
