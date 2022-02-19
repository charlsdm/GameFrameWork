using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Mono的管理者
/// 1.声明周期函数
/// 2.事件 
/// 3.协程
/// </summary>
public class MonoController : MonoBehaviour {

    private event UnityAction updateEvent;

    private event UnityAction fixedupdateEvent;

    private event UnityAction LateUpdateEvent;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        if (updateEvent != null)
            updateEvent();
    }

    void FixedUpdate()
    {
        if (fixedupdateEvent != null)
            fixedupdateEvent();
    }

    void LateUpdate()
    {
        if (LateUpdateEvent != null)
            LateUpdateEvent();
    }

    /// <summary>
    /// 给外部提供的 添加帧更新事件的函数
    /// </summary>
    /// <param name="fun"></param>
    public void AddUpdateListener(UnityAction fun)
    {
        updateEvent += fun;
    }

    /// <summary>
    /// 提供给外部 用于移除帧更新事件函数
    /// </summary>
    /// <param name="fun"></param>
    public void RemoveUpdateListener(UnityAction fun)
    {
        updateEvent -= fun;
    }

    /// <summary>
    /// 提供给外部 用于fixedUpdate更新事件的函数
    /// </summary>
    /// <param name="fun"></param>
    public void AddFixedUpdateListener(UnityAction fun)
    {
        fixedupdateEvent += fun;
    }

    /// <summary>
    /// 提供给外部用于 LateUpdate更新事件的函数
    /// </summary>
    /// <param name="fun"></param>
    public void AddLateUpdateListener(UnityAction fun)
    {
        LateUpdateEvent += fun;
    }

    /// <summary>
    /// 提供给外部用于移除fixedUpdate更新事件的函数
    /// </summary>
    /// <param name="fun"></param>
    public void RemoveFixedUpdateListener(UnityAction fun)
    {
        fixedupdateEvent -= fun;
    }

    /// <summary>
    /// 提供给外部用于移除LateUpdate更新事件的函数
    /// </summary>
    /// <param name="fun"></param>
    public void RemoveLateUpdateListener(UnityAction fun)
    {
        LateUpdateEvent -= fun;
    }


}
