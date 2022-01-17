using System;
using System.Reflection;
using UnityEngine;

namespace MyFramework
{
    //扩展类为静态类
    public static class MainExtend
    {
        #region 通用方法扩展

        //this需要扩展的类型，这里object是所有类型
        public static void LogType(this object obj)
        {
            Debug.Log(obj.GetType());
        }
        /// <summary>
        /// 获取自身属性
        /// </summary>
        public static T GetAttribute<T>(this object obj) where T:Attribute
        {
            //这里需要使用obj.GetType()获取属性
            return obj.GetType().GetCustomAttribute<T>();
        }
        /// <summary>
        /// 获取其他类属性
        /// </summary>
        public static T GetAttribute<T>(this object obj,Type type) where T:Attribute
        {
            //这里需要使用obj.GetType()获取属性
            return type.GetCustomAttribute<T>();
        }

        #endregion
    }
}

