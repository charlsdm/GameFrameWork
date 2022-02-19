using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMonoScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         MonoMgr.GetInstance().AddUpdateListener(DebugUpdateMsg);
        // MonoMgr.GetInstance().AddFixedUpdateListener(DebugFixedUpdateMsg);
        // MonoMgr.GetInstance().AddLateUpdateListener(DebugLateUpdateMsg);
        MonoMgr.GetInstance().StartCoroutine(waitSeconds());


        MonoMgr.GetInstance().Invoke<TestMonoScript>("DebugInvokeMsg", 2.0f,this);
        MonoMgr.GetInstance().InvokeRepeating<TestMonoScript>("DebugInvokeRepeatingMsg", 1.0f, 1.0f, this);
        //MonoMgr.GetInstance().Invoke<MonoBehaviour>("DebugInvokeMsg", 2.0f,this);

    }

    private void DebugInvokeMsg()
    {
        Debug.Log("Invoke开启");
    }

    private void DebugInvokeRepeatingMsg()
    {
        Debug.Log("InvokeRepeating开启");
    }

    private IEnumerator waitSeconds()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            Debug.Log("hello");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void DebugUpdateMsg()
    {
        //Debug.Log("Update");
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("停止协同程序");
            MonoMgr.GetInstance().StopAllCoroutines();
            Debug.Log("停止Invoke");
            MonoMgr.GetInstance().CancelInvoke(this);
            Debug.Log("停止CancelInvoke");
            
        }
    }

    private void DebugFixedUpdateMsg()
    {
        Debug.Log("FixedUpdateMsg");
    }

    private void DebugLateUpdateMsg()
    {
        Debug.Log("LateUpdateMsg");
    }

     void OnDestroy()
    {
        MonoMgr.GetInstance().RemoveUpdateListener(DebugUpdateMsg);
        MonoMgr.GetInstance().RemoveFixedUpdateListener(DebugFixedUpdateMsg);
        MonoMgr.GetInstance().RemoveLateUpdateListener(DebugLateUpdateMsg);
    }
}
