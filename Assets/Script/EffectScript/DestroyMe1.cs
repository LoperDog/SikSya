using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe1 : MonoBehaviour
{
    public Vector3 TargetPosition;
    void Start()
    {
        Destroy(transform.gameObject, 0.9f);
    }
    void Update()
    {
        transform.position = TargetPosition;
    }
    public void SetTargetPosition(Vector3 T) { TargetPosition = T; }
}