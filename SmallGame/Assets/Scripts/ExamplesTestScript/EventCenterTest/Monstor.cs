using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstor : MonoBehaviour
{
    public string Monstorname="MonstorName";
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("按了A键盘之后，怪物死亡");
            //第一种调用方法是为了其他脚本可以调用当前自身脚本的一些东西
            EventCenter.GetInstance().EventTrigger<Monstor>("怪物死亡", this);
            EventCenter.GetInstance().EventTrigger("怪物1死亡");
        }
    }
}
