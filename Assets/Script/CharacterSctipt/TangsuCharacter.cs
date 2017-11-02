using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangsuCharacter : CharacterSuper
{
    public TangsuAnimation CharAnim;

    override public void Attack()
    {

    }



    public override void SetAnimator(AnimationSuper anim)
    {
        base.SetAnimator(anim);
        CharAnim = (TangsuAnimation)anim;
    }
}