using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPoolMgrDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetGameObjectSomething(GameObject gameObject)
    {
        gameObject.transform.localScale = Vector3.one * 2;
    }

    public void SetGameObjectDebugSomething(GameObject gameObject)
    {
        Debug.Log("GameObjectDoSomething");
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            PoolMgr.GetInstance().GetObj("PoolRes/Cube", SetGameObjectSomething);
        }
        else if(Input.GetMouseButtonDown(1))
        {
            PoolMgr.GetInstance().GetObj("PoolRes/Sphere", SetGameObjectDebugSomething);
        }
    }
}
