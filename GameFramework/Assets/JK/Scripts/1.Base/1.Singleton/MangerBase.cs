using UnityEngine;

public abstract class MangerBase : MonoBehaviour
{
    public virtual void Init(){}
}
public abstract class MangerBase<T> : MangerBase where T:MangerBase<T>
{
    public static T Instance;
    /// <summary>
    /// 管理器初始化
    /// </summary>
    public override void Init()
    {
        Instance = this as T;
    }
}
