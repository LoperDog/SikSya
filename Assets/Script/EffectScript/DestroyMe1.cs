using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe1 : MonoBehaviour
{
    public Transform Target;
    void Start()
    {
        Destroy(transform.gameObject, 0.3f);
    }
    void Update()
    {
        transform.position = Target.transform.position;
    }
}