using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DubuHead : MonoBehaviour {
    private CharacterMgr MyMgr;
    private float LeftBullet;
	// Use this for initialization
	void Start () {
        MyMgr = transform.root.GetComponent<CharacterMgr>();
        LeftBullet = 0;
	}

    private void LateUpdate()
    {
        LeftBullet= MyMgr.Current_Bullet;
        float height = LeftBullet / 100;
        transform.localScale = new Vector3(1.0f - height, 1.0f, 1.0f);
    }
}
