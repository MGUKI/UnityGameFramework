using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFramework
{
    //IEquatable<T> 可以进行比较
    public class BindableProperty<T> where  T :IEquatable<T>
    {
        private T mValve = default(T);

        public T Valve
        {
            get => mValve;
            set
            {
                //如果Valve不等于mValve
                if (!value.Equals(mValve))
                {
                    mValve = value;
                    OnValueChanged?.Invoke(value);
                }
            }
        }

        public Action<T> OnValueChanged;
    }
}

