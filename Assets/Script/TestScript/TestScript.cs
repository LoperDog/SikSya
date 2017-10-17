using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    public coroutinTestSuper Test1;

	void Start () {
        Test1 = new coroutinTestSuper();
	}
	
	// Update is called once per frame
	void Update () {
        Test1.DeletaTimeUpdateTest();
	}
}
