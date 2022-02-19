using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 这个脚本是用于给物体进入到对象池中,只要是对象池的物体，都必须挂上这个脚本
/// </summary>
public class GameObjIntoPool : MonoBehaviour
{

    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("PushPool", 1.0f);
    }

    void PushPool()
    {
        PoolMgr.GetInstance().PushObj(this.gameObject.name, this.gameObject);
    }
}
