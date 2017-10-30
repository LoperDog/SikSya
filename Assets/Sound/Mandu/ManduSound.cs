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
        /*
        int random = Random.Range(0, Attack.Length - 1);
        GetComponent<AudioSource>().PlayOneShot(Attack[random]); 
        */
        GetComponent<AudioSource>().PlayOneShot(Attack);
    }

    public void SpecialAttackOnPlay()
    {
        GetComponent<AudioSource>().PlayOneShot(Skill);
    }

    public void WalkOnPlay()
    {
        int temprandom = Random.Range(0, Walk.Length - 1);
        GetComponent<AudioSource>().PlayOneShot(Walk[temprandom]);
    }
    public void RunOnPlay()
    {
        int temprandom = Random.Range(0, Run.Length - 1);
        GetComponent<AudioSource>().PlayOneShot(Run[temprandom]);
    }

    public void ReLoadOnPlay()
    {
        GetComponent<AudioSource>().PlayOneShot(ReLoad);
    }
    public void JumpStartOnPlay()
    {
        GetComponent<AudioSource>().PlayOneShot(JumpStart);
    }
    public void JumpEndOnPlay()
    {
        GetComponent<AudioSource>().PlayOneShot(JumpEnd);
    }

    public void LanddingEndOnPlay()
    {
        GetComponent<AudioSource>().PlayOneShot(LanddingEnd);
    }
    public void LanddingStartOnPlay()
    {
        GetComponent<AudioSource>().PlayOneShot(LanddingStart);
    }
}
