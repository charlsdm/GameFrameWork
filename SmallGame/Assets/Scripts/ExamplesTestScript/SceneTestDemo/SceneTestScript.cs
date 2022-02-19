using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneTestScript : MonoBehaviour
{
    public string name = "SceneTestDemo2";

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        EventCenter.GetInstance().AddEventListener<float>("进度条更新", GetProgress);
        ScenesMgr.GetInstance().LoadSceneAsyn(name, IntoNextScene2);

    }

    private void GetProgress(float arg0)
    {
        text.text = (arg0*100).ToString();
        Debug.Log("arg0:" + arg0);
    }

    public void IntoNextScene2()
    {
        Debug.Log("进入场景2");
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
