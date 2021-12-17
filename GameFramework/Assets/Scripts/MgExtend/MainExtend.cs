using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFramework
{
    //扩展类为静态类
    public static class MainExtend
    {
        //this需要扩展的类型，这里object是所有类型
        public static void LogType(this object obj)
        {
            Debug.Log(obj.GetType());
        }
    }
}

