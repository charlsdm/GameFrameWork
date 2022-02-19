using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventCenter.GetInstance().AddEventListener<Monstor>("怪物死亡", MonstorDieOtherGo);
    }

    private void MonstorDieOtherGo(Monstor monstor)
    {
        Debug.Log("Other要开启了");
    }

     void OnDestroy()
    {
        EventCenter.GetInstance().RemoveEventListener<Monstor>("怪物死亡", MonstorDieOtherGo);
    }
}
