using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITestDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UIManager.GetInstance().ShowPanel<LoginPanel>("Panel",E_UI_Layer.Mid,ShowPanelInit);
      
    }

    private void ShowPanelInit(LoginPanel arg0)
    {
        arg0.InitLoginPanel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
