using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoot : SingletonMono<GameRoot>
{
    public String testTxt = "GameRoot";

    protected override void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        base.Awake();
        DontDestroyOnLoad(gameObject);

        InitManger();
    }
    /// <summary>
    /// 初始化所有管理器
    /// </summary>
    private void InitManger()
    {
        MangerBase[] mangerBases = GetComponents<MangerBase>();
        for (int i = 0; i < mangerBases.Length; i++)
        {
            mangerBases[i].Init();
        }
    }
}
