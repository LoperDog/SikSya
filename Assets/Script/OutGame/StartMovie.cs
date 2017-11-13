using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConstValueInfo;

public class StartMovie : MonoBehaviour {

    public MovieTexture mTeamLogo;

    bool mIsPlayGameLogo = false;
    //Renderer mRen;
    // Use this for initialization
    void Start () {
        mTeamLogo.Play();
        //mRen = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if(!mIsPlayGameLogo && !mTeamLogo.isPlaying)
        {
            mIsPlayGameLogo = true;
            CheckState.ChangeSceneState(ProtocolSceneName.FrontScene);
        }
	}
}

/*
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConstValueInfo;

public class StartMovie : MonoBehaviour {

    public MovieTexture mTeamLogo;
    public MovieTexture mGameLogo;

    bool mIsPlayGameLogo = false;
    Renderer mRen;
    // Use this for initialization
    void Start () {
        mTeamLogo.Play();
        mRen = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if(!mIsPlayGameLogo && !mTeamLogo.isPlaying)
        {
            Debug.Log("여기");
            mRen.material.mainTexture = mGameLogo;
            mGameLogo.Play();
            mIsPlayGameLogo = true;
        }
        if(mIsPlayGameLogo && !mGameLogo.isPlaying)
        {
            CheckState.ChangeSceneState(ProtocolSceneName.FrontScene);
        }
	}
}
 
     */
