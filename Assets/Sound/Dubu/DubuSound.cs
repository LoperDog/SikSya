using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DubuSound : MonoBehaviour
{
    public AudioClip[] Attack;
    public AudioClip Strong;
    public AudioClip Special;

    public AudioClip[] Walk;
    public AudioClip[] Run;

    public AudioClip ReLoad;

    public AudioClip JumpStart;
    public AudioClip JumpEnd;

    public AudioClip LanddingStart;
    public AudioClip LanddingEnd;

    public void AttackOnPlay()
    {
        int random = Random.Range(0, Attack.Length);
        AudioSource.PlayClipAtPoint(Attack[random], transform.position);
        //Debug.Log(Attack[random].name);
    }

    public void StrongAttackOnPlay()
    {
        AudioSource.PlayClipAtPoint(Strong, transform.position);
        //Debug.Log(Strong.name);
    }
    public void SpecialAttackOnPlay()
    {
        AudioSource.PlayClipAtPoint(Special, transform.position);
        //Debug.Log(Special.name);
    }

    public void WalkOnPlay()
    {
        if (transform.GetComponent<CharacterMgr>().GetIsRun()) return;
        int temprandom = Random.Range(0, Walk.Length);
        AudioSource.PlayClipAtPoint(Walk[temprandom], transform.position);
        //Debug.Log(Walk[temprandom].name);
    }
    public void RunOnPlay()
    {
        if (!transform.GetComponent<CharacterMgr>().GetIsRun()) return;
        int temprandom = Random.Range(0, Run.Length);
        AudioSource.PlayClipAtPoint(Run[temprandom], transform.position);
        //Debug.Log(Run[temprandom].name);
    }

    public void ReLoadOnPlay()
    {
        AudioSource.PlayClipAtPoint(ReLoad, transform.position);
        //Debug.Log(ReLoad.name);
    }
    public void JumpStartOnPlay()
    {
        AudioSource.PlayClipAtPoint(JumpStart, transform.position);
        //Debug.Log(JumpStart.name);
    }
    public void JumpEndOnPlay()
    {
        AudioSource.PlayClipAtPoint(JumpEnd, transform.position);
        //Debug.Log(JumpEnd.name);
    }

    public void LanddingEndOnPlay()
    {
        AudioSource.PlayClipAtPoint(LanddingEnd, transform.position);
        //Debug.Log(LanddingEnd.name);
    }
    public void LanddingStartOnPlay()
    {
        AudioSource.PlayClipAtPoint(LanddingStart, transform.position);
        //Debug.Log(LanddingStart.name);
    }
}
