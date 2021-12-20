using System.Collections;
using System.Collections.Generic;
using MyFramework;
using UnityEngine;

public class GameObjectPoolData
{
    //对象池 父节点
    public GameObject fatherObj;
    //对象容器
    public Queue<GameObject> poolQueue;

    public GameObjectPoolData(GameObject obj, GameObject pooRootObj)
    {
        //创建父节点
        fatherObj = new GameObject(obj.name);
        //设置到对象池根节点下方
        fatherObj.transform.SetParent(pooRootObj.transform);

        poolQueue = new Queue<GameObject>();
        
        PushObj(obj);
    }
    
    /// <summary>
    /// 放进容器
    /// </summary>
    /// <param name="obj"></param>
    public void PushObj(GameObject obj)
    {
        poolQueue.Enqueue(obj);
        //Obj设置父物体
        obj.transform.SetParent(fatherObj.transform);
        // 隐藏
        obj.SetActive(false);
    }
    /// <summary>
    /// 拿出去
    /// </summary>
    /// <returns></returns>
    public GameObject GetObj()
    {
        GameObject obj = poolQueue.Dequeue();
        return null;
    }
}
