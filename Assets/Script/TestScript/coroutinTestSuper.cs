using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutinTestSuper : MonoBehaviour {

    public float test;

    public coroutinTestSuper()
    {
        // 코루틴은 사용할수 없다.
        //StartCoroutine(TestScript1());
        //StartCoroutine(TestScript2(1.5f));
        test = 0.0f;
    }
    public void DeletaTimeUpdateTest()
    {
        Debug.Log(test);
        test += Time.deltaTime;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator TestScript1()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            Debug.Log("I'm Doing Test");
        }
    }
    IEnumerator TestScript2(float T)
    {
        while (true)
        {
            yield return new WaitForSeconds(T);
            Debug.Log("I'm Doing Test2 in value : " + T);
        }
    }
}
