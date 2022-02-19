using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    public int[] intid = new int[] { 1, 2, 3 };
    // Start is called before the first frame update
    void Start()
    {
        EventCenter.GetInstance().AddEventListener<Monstor>("怪物死亡", MonstorDieGetTask);
    }

    private void MonstorDieGetTask(Monstor monstor)
    {
        Debug.Log(monstor.Monstorname + "被杀了，任务完成了");
    }

    void OnDestroy()
    {
        EventCenter.GetInstance().RemoveEventListener<Monstor>("怪物死亡", MonstorDieGetTask);
    }
    // Update is called once per frame

}
