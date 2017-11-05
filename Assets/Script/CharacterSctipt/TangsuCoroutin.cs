using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangsuCoroutin : CoroutinClass
{
    public TangsuCharacter TangsuChar;

    public override void SetCharacterScript(CharacterSuper CharacterClass)
    {
        base.SetCharacterScript(CharacterClass);
        TangsuChar = (TangsuCharacter)CharacterClass;
    }

    //강공격
    public override void StartStrongAttckSetting()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
    }
}
