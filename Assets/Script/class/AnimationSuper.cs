using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSuper
{
    protected Animator m_Anim;
    protected CharacterSuper m_Char_State;
    protected ConfigClass m_Config;
        
    public AnimationSuper()
    {

    }
    public virtual void PlayAnimation() // 애니매이션 플레이
    {
        PlayMove();
        PlayRun();
        PlayJump(); 
        PlayAttack();
        PlayReload();
        Long_Landing();
        SetTaunt1();
        SetTaunt2();
        PlayDie();
    }
    public virtual void Long_Landing()//시작 착지 애니메이션
    {
        if (m_Char_State.GetIsGroud())
        {
            m_Anim.SetBool("Long_Landing", true);
        }
    }
    public virtual void PlayMove() // 이동
    {
        m_Anim.SetFloat("H",m_Char_State.GetMoveH());
        m_Anim.SetFloat("V",m_Char_State.GetMoveV());
    }
    public virtual void PlayRun()//뛰기
    {
        m_Anim.SetFloat("Speed", m_Char_State.GetSpeed());
    }
    public virtual void PlayJump() //점프
    {
        m_Anim.SetBool("Falling", m_Char_State.GetIsJump());
    }
    public virtual void PlayAttack()// 공격
    {
        //m_Anim.SetBool("Is_Attack", m_Char_State.GetIsAttack());
    }
    public virtual void PlayReload()// 재장전
    {
        m_Anim.SetBool("Reload", m_Char_State.GetIsReload());
    }
    //도발
    public void SetTaunt1()//1번 도발
    {
        m_Anim.SetBool("Taunt1", m_Char_State.GetIsTaunt1());
    }
    public void SetTaunt2()//2번 도발
    {
        m_Anim.SetBool("Taunt2", m_Char_State.GetIsTaunt2());
    }
    public virtual void PlayDie()//사망
    {
        if (m_Char_State.GetIsDead())
        {
            m_Anim.SetTrigger("Dead");
            if (m_Anim.GetCurrentAnimatorStateInfo(0).IsName("Move.Die") && m_Anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.88f)
            {
                m_Anim.Stop();
            }
        }
    }
    public virtual void SetChar(CharacterSuper CharScript) { m_Char_State = CharScript; }

    public virtual void SetAnimator( Animator anim) { m_Anim = anim; }

    ~AnimationSuper()
    {
        m_Anim = null;
    }
}
