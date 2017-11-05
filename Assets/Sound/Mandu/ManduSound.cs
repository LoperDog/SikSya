using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManduSound : MonoBehaviour {
    public AudioClip Attack;
    public AudioClip Skill;

    public AudioClip[] Walk;
    public AudioClip[] Run;

    public AudioClip ReLoad;

    public AudioClip JumpStart;
    public AudioClip JumpEnd;

    public AudioClip LanddingStart;
    public AudioClip LanddingEnd;

    public void AttackOnPlay()
    {
        AudioSource.PlayClipAtPoint(Attack, transform.position);
    }

    public void SpecialAttackOnPlay()
    {
        AudioSource.PlayClipAtPoint(Attack, transform.position);
    }

    public void WalkOnPlay()
    {
        if (transform.GetComponent<CharacterMgr>().GetIsRun()) return;
        int temprandom = Random.Range(0, Walk.Length);
        AudioSource.PlayClipAtPoint(Walk[temprandom], transform.position);
    }
    public void RunOnPlay()
    {
        if (!transform.GetComponent<CharacterMgr>().GetIsRun()) return;
        int temprandom = Random.Range(0, Run.Length);
        AudioSource.PlayClipAtPoint(Run[temprandom], transform.position);
    }

    public void ReLoadOnPlay()
    {
        AudioSource.PlayClipAtPoint(ReLoad, transform.position);
    }
    public void JumpStartOnPlay()
    {
        AudioSource.PlayClipAtPoint(JumpStart, transform.position);
    }
    public void JumpEndOnPlay()
    {
        AudioSource.PlayClipAtPoint(JumpEnd, transform.position);
    }

    public void LanddingEndOnPlay()
    {
        AudioSource.PlayClipAtPoint(LanddingEnd, transform.position);
    }
    public void LanddingStartOnPlay()
    {
        AudioSource.PlayClipAtPoint(LanddingStart, transform.position);
    }
}
