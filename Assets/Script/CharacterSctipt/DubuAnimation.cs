using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DubuAnimation : AnimationSuper
{
    DubuCharacter CharacterScript;

    public override void SetChar(CharacterSuper CharScript)
    {
        base.SetChar(CharScript);
        CharacterScript = (DubuCharacter)CharScript;
    }
    //공격
    public override void PlayAttack()
    {
        m_Anim.SetBool("Is_Attack", m_Char_State.GetIsAttack());
        m_Anim.SetBool("LeftAttack", CharacterScript.AttackIsLeft);
        m_Anim.SetBool("RightAttack", !CharacterScript.AttackIsLeft);
    }
    //강공격
    public void SetStrongAttackReady()
    {
        m_Anim.SetBool("Is_StrongAttack", true);
    }
    public void SetStrongAttackDash()
    {

    }
    public void SetStrongAttackEnd()
    {
        m_Anim.SetBool("Is_StrongAttack", false);
    }
    //특수기
    public void SetSpecialAttackReady()
    {
        m_Anim.SetBool("Is_SpecialAttack", true);
    }
    public void SetSpecialAttackEnd()
    {
        m_Anim.SetBool("Is_SpecialAttack", false);
    }
}

