using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConstValueInfo;


public class RoomInfo : MonoBehaviour {

    [SerializeField]
    Sprite[] mTeamAmountSprite = new Sprite[3];
    [SerializeField]
    Sprite[] mRoomPrivatePublicSprite = new Sprite[2];

    public Sprite GetTeamAmountSprite(ProtocolTeamAmount teamAmount)
    {
        return mTeamAmountSprite[(int)teamAmount];
    }

    public Sprite GetRoomPrivatePublicSprite(ProtocolRoomPrivatePublic PP)
    {
        return mRoomPrivatePublicSprite[(int)PP];
    }

}
