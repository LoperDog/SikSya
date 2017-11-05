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
