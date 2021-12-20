using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFramework
{
    public class Event<T> where T : Event<T>
    {
        private static Action mOnEvent;
        /// <summary>
        /// 注册事件
        /// </summary>
        /// <param name="onEvent"></param>
        public static void Register(Action onEvent)
        {
            mOnEvent += onEvent;
        }
        /// <summary>
        /// 注销事件
        /// </summary>
        /// <param name="onEvent"></param>
        public static void UnRegister(Action onEvent)
        {
            mOnEvent -= onEvent;
        }
        /// <summary>
        /// 触发事件
        /// </summary>
        public static void Trigger()
        {
            // if (mOnEvent != null)
            // {
            //     mOnEvent.Invoke();
            // }
            mOnEvent?.Invoke();
        }
    }
}

