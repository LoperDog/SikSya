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
}
