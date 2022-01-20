using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject cube;
    public GameObject sp;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            var testPoolCube = PoolManager.Instance.GetGameObject<TestPoolCube>(cube);
            testPoolCube.cube();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            var testPoolSp = PoolManager.Instance.GetGameObject<TestPoolSp>(sp);
            testPoolSp.sp();
        }
    }
}

