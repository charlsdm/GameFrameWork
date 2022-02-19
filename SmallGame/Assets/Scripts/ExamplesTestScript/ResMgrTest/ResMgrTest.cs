using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResMgrTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ResMgr.GetInstance().LoadAsync<GameObject>("PoolRes/Cube", (obj) => {
            obj.transform.localScale = Vector3.one * 5;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
