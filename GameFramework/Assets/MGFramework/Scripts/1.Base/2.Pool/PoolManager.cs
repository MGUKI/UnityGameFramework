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
    /// <summary>
    /// 普通类 对象容器
    /// </summary>
    public Dictionary<string, ObjectPoolData> ObjectPoolDie = new Dictionary<string, ObjectPoolData>();
    public override void Init()
    {
        base.Init();
        Debug.Log("PoolManager 初始化成功");
    }

    #region GameObject对象相关操作

    /// <summary>
    /// 获取GameObject
    /// </summary>
    /// <param name="prefab"></param>
    /// <typeparam name="T">最终组件</typeparam>
    /// <returns></returns>
    public T GetGameObject<T>(GameObject prefab,Transform parent = null) where T : UnityEngine.Object
    {
        GameObject obj = GetGameObject(prefab,parent);
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
    public GameObject GetGameObject(GameObject prefab,Transform parent = null)
    {
        GameObject obj = null;
        string name = prefab.name;
        if (CheckGameObjectCache(prefab))
        {
            obj = gameObjPoolDie[name].GetObj(parent);
        }
        else
        {
            obj = GameObject.Instantiate(prefab,parent);
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

    #endregion

    #region Object对象相关操作

    public T GetObject<T>() where T : class,new()
    {
        T obj;
        if (CheckObjectCache<T>())
        {
            string name = typeof(T).FullName;
            obj = (T)ObjectPoolDie[name].GetObj();
            return obj;
        }
        else
        {
            return new T();
        }
    }

    public bool CheckObjectCache<T>()
    {
        string name = typeof(T).FullName;
        return ObjectPoolDie.ContainsKey(name) && ObjectPoolDie[name].poolQueue.Count > 0;
    }

    public void PushObject(object obj)
    {
        string name = obj.GetType().FullName;
        // 
        if (ObjectPoolDie.ContainsKey(name))
        {
            ObjectPoolDie[name].PushObj(obj);
        }
        else
        {
            ObjectPoolDie.Add(name,new ObjectPoolData());
        }
    }

    #endregion

    /// <summary>
    /// gameObjPoolDie置空
    /// </summary>
    public void Clear(bool clearObjectClss = true)
    {
        gameObjPoolDie.Clear();
        if (clearObjectClss)
        {
            ObjectPoolDie.Clear();
        }
    }
}
