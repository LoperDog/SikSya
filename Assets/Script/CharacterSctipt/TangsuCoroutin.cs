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

    //일반공격
    public override IEnumerator SetAttackState()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;//제어불가
        thisCharacterScript.Is_Attack = true;//공격시작
        yield return new WaitForSeconds(thisMgr.StrongAttackCoolTime = config.StatusConfigs ["Tangsu"] ["Atttack1_Start"]);//1타
        StartCoroutine(Attack1End());
    }
    public IEnumerator Attack1End()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = true;//제어가능
        yield return new WaitForSeconds(thisMgr.StrongAttackCoolTime = config.StatusConfigs ["Tangsu"] ["Atttack1_End"]);//1타끝
        thisCharacterScript.Is_Attack = false;//공격 끝
    }
}
