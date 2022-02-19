using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventCenter.GetInstance().AddEventListener("怪物1死亡", MonstorDiePlayerSomething);
    }

    private void MonstorDiePlayerSomething()
    {
        Debug.Log("Player胜利哈哈");
    }

     void OnDestroy()
    {
        EventCenter.GetInstance().RemoveEventListener("怪物1死亡", MonstorDiePlayerSomething);
    }
    // Update is called once per frame

}
