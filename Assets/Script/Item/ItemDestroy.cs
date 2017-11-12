using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {
    public void DestroyMe()
    {
        Destroy(transform);
    }
}
