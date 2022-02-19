using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 1.可以提供给外部添加帧更新事件的方法
/// 2.可以提供给外部添加 协程的方法
/// 3.可以提供给外部添加Invoke,InvokeRepeating函数之类，暂停协程，CancelInvoke之类的
/// </summary>
public class MonoMgr : BaseManager<MonoMgr>
{
    private MonoController controller;

    public MonoMgr()
    {
        //保证了MonoController对象的唯一性
        GameObject obj = new GameObject("MonoController");
        controller = obj.AddComponent<MonoController>();
    }

    /// <summary>
    /// 给外部提供的 添加帧更新事件的函数
    /// </summary>
    /// <param name="fun"></param>
    public void AddUpdateListener(UnityAction fun)
    {
        controller.AddUpdateListener(fun);
    }

    /// <summary>
    /// 提供给外部 用于移除帧更新事件函数
    /// </summary>
    /// <param name="fun"></param>
    public void RemoveUpdateListener(UnityAction fun)
    {
        controller.RemoveUpdateListener(fun);
    }

    /// <summary>
    /// 提供给外部fixedupdate更新事件
    /// </summary>
    /// <param name="fun"></param>
    public void AddFixedUpdateListener(UnityAction fun)
    {
        controller.AddFixedUpdateListener(fun);
    }

    /// <summary>
    /// 提供给外部移除fixedupdate更新事件
    /// </summary>
    /// <param name="fun"></param>
    public void RemoveFixedUpdateListener(UnityAction fun)
    {
        controller.RemoveFixedUpdateListener(fun);
    }
    /// <summary>
    /// 提供给外部添加lateupdate更新事件
    /// </summary>
    /// <param name="fun"></param>
    public void AddLateUpdateListener(UnityAction fun)
    {
        controller.AddLateUpdateListener(fun);
    }

    /// <summary>
    /// 提供给外部移除lateupdate更新事件
    /// </summary>
    /// <param name="fun"></param>
    public void RemoveLateUpdateListener(UnityAction fun)
    {
        controller.RemoveLateUpdateListener(fun);
    }


    public Coroutine StartCoroutine(IEnumerator routine)
    {
        return controller.StartCoroutine(routine);
    }

    public Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value)
    {
        return controller.StartCoroutine(methodName, value);
    }

    public Coroutine StartCoroutine(string methodName)
    {
        return controller.StartCoroutine(methodName);
    }

    public void StopAllCoroutines()
    {
        controller.StopAllCoroutines();
    }

    public void StopCoroutine(IEnumerator routine)
    {
        controller.StopCoroutine(routine);
    }

    public void StopCoroutine(Coroutine routine)
    {
        controller.StopCoroutine(routine);
    }

    public void StopCoroutine(string methodName)
    {
        controller.StopCoroutine(methodName);
    }

    public void CancelInvoke<T>(string methodName,T mono)
    {
       (mono as MonoBehaviour).CancelInvoke(methodName);
    }
    public void CancelInvoke<T>(T mono)
    {
       (mono as MonoBehaviour).CancelInvoke();
    }

    

    public void Invoke<T>(string methodName, float time,T mono)
    {
        
       (mono as MonoBehaviour).Invoke(methodName, time);
    }
    public void InvokeRepeating<T>(string methodName, float time, float repeatRate,T mono)
    {
      (mono as MonoBehaviour).InvokeRepeating(methodName, time, repeatRate);
    }
    public bool IsInvoking<T>(string methodName,T mono)
    {
       return (mono as MonoBehaviour).IsInvoking(methodName);
    }
    
    public bool IsInvoking<T>(T mono)
    {
        return (mono as MonoBehaviour).IsInvoking();
    }


}
