using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTestDemoScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InputMgr.GetInstance().StartOrEndCheck(true);
        EventCenter.GetInstance().AddEventListener<KeyCode>("某键按下", CheckInputDown);
        EventCenter.GetInstance().AddEventListener<KeyCode>("某键抬起", CheckInputUp);
       
    }
    /// <summary>
    /// 这是关联按键抬起来的东西
    /// </summary>
    /// <param name="arg0">传入来的是KeyCode</param>
    private void CheckInputUp(KeyCode arg0)
    {
        switch (arg0)
        {
            case KeyCode.W:Debug.Log("W抬起"); break;
            case KeyCode.S:Debug.Log("S抬起"); break;
            case KeyCode.A:Debug.Log("A抬起"); break;
            case KeyCode.D:Debug.Log("D抬起"); break;
        }

    }

    private void CheckInputDown(KeyCode arg0)
    {
        switch (arg0)
        {
            case KeyCode.W: Debug.Log("W按下"); break;
            case KeyCode.S: Debug.Log("S按下"); break;
            case KeyCode.A: Debug.Log("A按下"); break;
            case KeyCode.D: Debug.Log("D按下"); break;
        }
    }



    
}
