using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPoolCube : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Debug.Log("生成了一个Cube");
        Invoke("Dead",3);
    }

    void Dead()
    {
        PoolManager.Instance.PushGameObject(gameObject);
    }

    public void cube()
    {
        Debug.Log("cube调用成功");
    }
}
