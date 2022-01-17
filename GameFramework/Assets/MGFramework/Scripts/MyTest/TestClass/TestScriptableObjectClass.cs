using System.Collections;
using System.Collections.Generic;
using MyFramework;
using UnityEngine;

public class TestScriptableObjectClass : MonoBehaviour
{
    //GameConfig是一个资源也是一个实例
    public GameConfig gameConfig;
    private GameConfig gameConfig1;

    void Start()
    {
        #region Asset两种加载方式

        //拖拽加载
        Debug.Log("拖拽加载方式："+gameConfig.num);
        
        //动态加载 项目里需要创建Resourcesw文件夹
        gameConfig1 = Resources.Load<GameConfig>("MyGameConfig");
        Debug.Log("动态加载方式："+gameConfig1.num);

        #endregion
    }
    
    void Update()
    {
        
    }
}
