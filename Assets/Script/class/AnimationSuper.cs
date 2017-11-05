using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSuper
{
    protected Animator m_Anim;
    protected CharacterSuper m_Char_State;
    protected ConfigClass m_Config;
    protected CharacterMgr m_Mgr;
        
    public AnimationSuper()
    {

    }
    public virtual void PlayAnimation() // 애니매이션 플레이
    {
        Long_Landing();
        PlayMove();
        PlayRun();
        PlayJump(); 
        PlayAttack();
        PlayReload();
        SetTaunt1();
        SetTaunt2();
        PlayDie();
    }
    public virtual void Long_Landing()
    {
        m_Anim.SetBool("Long_Landing", !m_Char_State.Long_Falling);
    }
    public virtual void PlayMove()
    {
        m_Anim.SetFloat("H", m_Mgr.keyh);
        m_Anim.SetFloat("V", m_Mgr.keyv);
    }
    public virtual void PlayRun()
    {

        m_Anim.SetFloat("Speed", m_Char_State.GetSpeed());
    }
    public virtual void PlayJump()
    {
        m_Anim.SetBool("Falling", m_Char_State.GetIsJump());
    }
    public virtual void PlayAttack()
    {

    }
    public virtual void PlayReload()
    {
        m_Anim.SetBool("Reload", m_Char_State.GetIsReload());
    }
    public void SetTaunt1()
    {
        m_Anim.SetBool("Taunt1", m_Char_State.GetIsTaunt1());
    }
    public void SetTaunt2()
    {
        m_Anim.SetBool("Taunt2", m_Char_State.GetIsTaunt2());
    }
    public virtual void PlayDie()
    {
        m_Anim.SetBool("Dead", m_Char_State.GetIsDead());
    }
    public virtual void SetChar(CharacterSuper CharScript) { m_Char_State = CharScript; }

    public virtual void SetAnimator( Animator anim) { m_Anim = anim; }
    public virtual void SetMgr(CharacterMgr mgr) { m_Mgr = mgr; }
    ~AnimationSuper()
    {
        m_Anim = null;
    }
}
