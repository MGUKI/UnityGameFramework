using System;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : ManagerBase<PoolManager>
{
    [SerializeField] private GameObject poolRotObj;
    /// <summary>
    /// GameObject 对象容器
    /// </summary>
    public Dictionary<string, GameObjectPoolData> gameObjPoolDie = new Dictionary<string, GameObjectPoolData>();
    public override void Init()
    {
        base.Init();
        Debug.Log("PoolManager 初始化成功");
    }
    /// <summary>
    /// 获取GameObject
    /// </summary>
    /// <param name="prefab"></param>
    /// <typeparam name="T">最终组件</typeparam>
    /// <returns></returns>
    public T GetGameObject<T>(GameObject prefab) where T : UnityEngine.Object
    {
        GameObject obj = GetGameObject(prefab);
        if (obj != null)
        {
            return obj.GetComponent<T>();
        }
        return null;
    }
    /// <summary>
    /// 获取GameObject
    /// </summary>
    /// <param name="prefab"></param>
    /// <returns></returns>
    public GameObject GetGameObject(GameObject prefab)
    {
        GameObject obj = null;
        string name = prefab.name;
        if (CheckGameObjectCache(prefab))
        {
            obj = gameObjPoolDie[name].GetObj();
        }
        else
        {
            obj = GameObject.Instantiate(prefab);
            obj.name = name;
        }
        return obj;
    }
    /// <summary>
    /// GameObject放进对象池
    /// </summary>
    /// <param name="obj"></param>
    public void PushGameObject(GameObject obj)
    {
        string name = obj.name;
        if (gameObjPoolDie.ContainsKey(name))
        {
            gameObjPoolDie[name].PushObj(obj);
        }
        else
        {
            gameObjPoolDie.Add(name,new GameObjectPoolData(obj,poolRotObj));
        }
    }
    /// <summary>
    /// 检查有没有某一层对象池数据
    /// </summary>
    /// <param name="prefab"></param>
    /// <returns></returns>
    public bool CheckGameObjectCache(GameObject prefab)
    {
        string name = prefab.name;
        return gameObjPoolDie.ContainsKey(name) && gameObjPoolDie[name].poolQueue.Count > 0;
    }
    /// <summary>
    /// gameObjPoolDie置空
    /// </summary>
    public void Clear()
    {
        gameObjPoolDie.Clear();
    }
}
