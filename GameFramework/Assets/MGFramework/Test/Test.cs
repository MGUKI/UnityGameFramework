using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject cube;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PoolManager.Instance.GetGameObject<TestPoolCube>(cube);
        }
    }
}
