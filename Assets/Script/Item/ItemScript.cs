using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour {
    Transform tr;
    BoxCollider Mycoll;
    MeshRenderer MyMesh;
    float RespawnTime = 10f;


    //CharacterSuper.ItemCode this
	// Use this for initialization
	void Start () {
        tr = transform;
        Mycoll = tr.GetComponent<BoxCollider>();
        MyMesh = tr.GetComponent<MeshRenderer>();
	}

    private void OnTriggerEnter(Collider other)
    {
        // 플레이어한테 부딫혔다면.
        if(other.tag == "PLAYER")
        {
            other.GetComponent<CharacterMgr>().IGetMyItem();
            Mycoll.enabled = false;
            MyMesh.enabled = false;
            StartCoroutine(SetEnVisibleAndReSet());
        }
    }
    
    public IEnumerator SetEnVisibleAndReSet()
    {
        yield return new WaitForSeconds(RespawnTime);
        MyMesh.enabled = true;
        Mycoll.enabled = true;
    }
}
