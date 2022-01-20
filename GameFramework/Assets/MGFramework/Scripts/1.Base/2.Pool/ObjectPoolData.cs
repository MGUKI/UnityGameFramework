using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolData
{
    public Queue<object> poolQueue = new Queue<object>();
    public void PushObj(object obj)
    {
        poolQueue.Enqueue(obj);
    }

    public object GetObj()
    {
        return poolQueue.Dequeue();
    }
}
