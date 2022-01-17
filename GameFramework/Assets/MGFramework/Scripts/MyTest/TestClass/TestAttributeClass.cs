using MyFramework;
using UnityEngine;
[TestAttribute(true)]
public class TestAttributeClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //属性根实例没关系，使用选择使用typeof()
        //TestAttribute testAttribute= this.GetType().GetCustomAttribute<TestAttribute>();
        //属性需要通过反射获取到属性数据
        //TestAttribute testAttribute= typeof(TestAttributeClass).GetCustomAttribute<TestAttribute>();
        //扩展方法 MainExtend.GetAttribute
        TestAttribute testAttribute = this.GetAttribute<TestAttribute>();
        //获取Game类上的TestAttribute属性
        TestAttribute testAttribute1 = this.GetAttribute<TestAttribute>(typeof(Game));
        if (testAttribute.canSwitch)
        {
            Debug.Log("TestAttribute");
        }
    }
}
