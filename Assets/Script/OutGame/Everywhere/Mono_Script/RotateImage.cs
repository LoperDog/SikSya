using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConstValueInfo;

public class RotateImage : MonoBehaviour {

    RectTransform mRectTransform;

    // Use this for initialization
    void Awake () {
        mRectTransform = this.GetComponent<RectTransform>();
        //mRectTransform.anchoredPosition = new Vector2(0.5f, 0.5f);
    }

    public void StartRotate()
    {
        StartCoroutine("CoRotateImage");
    }

    IEnumerator CoRotateImage()
    {
        Vector3 rotVec3 = new Vector3();
        rotVec3.z = -30.0f; 
        while (true)
        {
            mRectTransform.Rotate(rotVec3);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
