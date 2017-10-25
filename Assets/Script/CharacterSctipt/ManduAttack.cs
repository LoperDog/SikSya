using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManduAttack : CloseAttack
{

    //무언가에 닿았다
    public virtual void OnTriggerEnter(Collider other)
    {
        Transform tempTransForm = other.GetComponent<Transform>();
        if (tempTransForm.tag == "PLAYER")
        {
            // 만약 자기 자신이라면
            if (tempTransForm == Player)
            {
                Debug.Log("플레이어에 닿았음.");
                return;
            }
            //자신이 아니라면....
            int tempIndex = -1;
            for (int i = 0; i < 6; i++)
            {
                tempIndex = i;
                // 만약 이미 있는 것이라면
                if (Target_NetworkView[i] == tempTransForm.GetComponent<NetworkView>())
                {
                    return;
                }
            }

            Vector3 qu = transform.position - tempTransForm.position;

            Instantiate(effect, tempTransForm.position, Quaternion.LookRotation(qu));

            Target_NetworkView[tempIndex] = tempTransForm.GetComponent<NetworkView>();
            AttackPlayer(Target_NetworkView[tempIndex]);
        }
    }
}
