using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    public ConfigSetting _configSetting;
    private void Start()
    {
        Debug.Log(_configSetting.GetConfig<DemoConfig>("武器",1).Name);
    }

    private void Update()
    {

    }
}

