using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPoolSp : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Debug.Log("生成了一个sp");
        Invoke("Dead",3);
    }
    void Dead()
    {
        PoolManager.Instance.PushGameObject(gameObject);
    }
    public void sp()
    {
        Debug.Log("sp调用成功");
    }
}
