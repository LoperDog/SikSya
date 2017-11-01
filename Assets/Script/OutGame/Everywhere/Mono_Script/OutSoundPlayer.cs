using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConstValueInfo;

public class OutSoundPlayer : MonoBehaviour {
    static Transform mMainCameraTr;
    [SerializeField]
    AudioClip[] OutAudio = new AudioClip[2];
    static AudioClip[] OutAudio2 = new AudioClip[2];
    static AudioSource mAudioSource;
    // Use this for initialization
    void Awake () {
        DontDestroyOnLoad(this.gameObject);
        mMainCameraTr = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
        OutAudio2[(int)SoundClip.Click] = OutAudio[(int)SoundClip.Click];
        OutAudio2[(int)SoundClip.RollOver] = OutAudio[(int)SoundClip.RollOver];
        mAudioSource = GetComponent<AudioSource>();
    }

    public static void PlayClickSound(SoundClip clip)
    {
        if(mAudioSource.isPlaying)
        {
            mAudioSource.Stop();
        }
        if(mMainCameraTr == null)
        {
            mMainCameraTr = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
        }
        AudioSource.PlayClipAtPoint(OutAudio2[(int)clip], mMainCameraTr.transform.position);
    }

    public void PlayRollOverSound()
    {
        if (mAudioSource.isPlaying)
        {
            mAudioSource.Stop();
        }
        if (mMainCameraTr == null)
        {
            mMainCameraTr = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
        }
        AudioSource.PlayClipAtPoint(OutAudio2[(int)SoundClip.RollOver], mMainCameraTr.transform.position);
    }

}
