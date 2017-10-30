using System.Collections;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private Transform tr;
    public Transform Player;

    public float Height = 1.3f; //높이
    public float Dist = 2.8f;//거리
    public float ViewRight = 1.0f;
    public float mouse_y_speed = 100.0f;//상하 회전속도
    public float Max_y = 320.0f;//최대각
    public float Min_y = 50.0f; //최소각

    public float x = 0.0f;
    public float y = 0.0f;


    void Awake()
    {
        tr = GetComponent<Transform>();

        Vector3 angle = tr.eulerAngles;
        x = angle.x;
        y = angle.y;
    }

    void LateUpdate()
    {
        if (Player)
        {
            // 길이 제기
            //Dist -= .5f * Input.mouseScrollDelta.y;

            x += Input.GetAxis("Mouse X") * mouse_y_speed * 0.02f;
            y += -Input.GetAxis("Mouse Y") * mouse_y_speed * 0.02f;

            y = y < -40 ? -40 : y;
            y = y > 40 ? 40 : y;
            //y = ClamAngle(y);

            Quaternion rotation = Quaternion.Euler(y, x, 0);
            Vector3 position = rotation * new Vector3(ViewRight, Height, -Dist) + Player.position + new Vector3(0.0f, 0.0f, 0.0f);


            tr.rotation = rotation;
            tr.position = position;
        }
    }
    public void SetPlayer(Transform Pl)
    {
        Player = Pl;
    }
}