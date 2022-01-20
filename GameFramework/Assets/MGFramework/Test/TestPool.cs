using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPool
{
    public void Init()
    {
        Debug.Log("生成了");
    }

    public void Dead()
    {
        Debug.Log("销毁了");
        PoolManager.Instance.PushObject(this);
    }

}
