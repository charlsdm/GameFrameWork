using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LoginPanel : BasePanel
{
    // Start is called before the first frame update
    void Start()
    {
        UIManager.AddCustomEventListener(GetControl<Button>("Start"), EventTriggerType.PointerExit, (data) => { Debug.Log("byebye"); });
        //UIManager.AddCustomEventListener(GetControl<Button>("Start"), EventTriggerType.PointerEnter, PointerAction);
        //GetControl<Button>("Start").onClick.AddListener(() => { Debug.Log("点击游戏开始"); });
        //GetControl<Button>("End").onClick.AddListener(() => { Debug.Log("点击游戏离开"); });
    }

    private void PointerAction(BaseEventData arg0)
    {
        Debug.Log("进入");
    }

    public void InitLoginPanel()
    {
        Debug.Log("初始化Login面板完成");
    }

    protected override void ButtonOnClick(string btnName)
    {
        switch(btnName)
        {
            case "Start":Debug.Log("开是");break;
            case "End":Debug.Log("结束");break;
        }
    }


    protected override void SliderOnValueChanged(string slidername, float value)
    {
        switch (slidername)
        {
            case "Slider":Debug.Log("Slider");
                if (value >= 0.5f)
                    Debug.Log("0.5f");
                break;

        }
        
    }
    // Update is called once per frame

}
