using System.Runtime.InteropServices;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConstValueInfo;

public class CReadyNetWork
{
    private static CReadyNetWork mInstance;
    private TcpClient mClient;// = new TcpClient();
    private NetworkStream mStream;
    private string mIP;
    private int mPort;
    private string mPortStr;

    private CReadyNetWork()
    {
        CReader.GetInstance().LoadTextFile(ref mIP, ConstValue.ServerIP_TextName);
        CReader.GetInstance().LoadTextFile(ref mPortStr, ConstValue.ServerPort_TextName);
        if (mIP == null)
        {
            UnityEngine.Debug.Log("IP정보 파일 못 읽음");
            mIP = "192.168.30.37";
        }
        if (mPortStr != null)
        {
            mPort = int.Parse(mPortStr);
        }
        else
        {
            UnityEngine.Debug.Log("Port정보 파일 못 읽음");
            mPort = 9000;
        }
        mClient = new TcpClient();
        mClient.Connect(mIP, mPort);
        mStream = mClient.GetStream();
    }
    ~CReadyNetWork()
    {
        UnityEngine.Debug.Log("CReadyNetWork 소멸자 호출");
        mStream.Close();
        mClient.Close();
    }
    public static CReadyNetWork GetInstance()
    {
        if (null == mInstance)
        {
            mInstance = new CReadyNetWork();
        }
        return mInstance;
    }

    public bool IsConnected()
    {
        return mClient.Connected;
    }

    public NetworkStream GetStream()
    {
        return mStream;
    }

    public void CloseStream()
    {
        UnityEngine.Debug.Log("mStream Close() 호출");
        mStream.Close();
    }

    public void CloseClient()
    {
        UnityEngine.Debug.Log("mClient Close() 호출");
        mClient.Close();
    }

}
