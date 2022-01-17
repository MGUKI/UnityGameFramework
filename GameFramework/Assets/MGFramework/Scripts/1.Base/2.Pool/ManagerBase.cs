using UnityEngine;
//让ManagerBase<T>继承自ManagerBase，这样就可以通过ManagerBase[]存储不同的ManagerBase<T>
public abstract class ManagerBase : MonoBehaviour
{
    public virtual void Init(){}
}
public abstract class ManagerBase<T> : ManagerBase where T:ManagerBase<T>
{
    public static T Instance;
    /// <summary>
    /// 管理器初始化方法
    /// </summary>
    public override void Init()
    {
        Instance = this as T;
    }
}
