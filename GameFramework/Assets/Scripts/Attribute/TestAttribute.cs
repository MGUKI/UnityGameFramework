using System;

//限制属性，AttributeTargets限制使用范围，AllowMultiple是否可以挂多个 类似[TestAttribute][TestAttribute]
[AttributeUsage(AttributeTargets.Class|AttributeTargets.Field,AllowMultiple = true)]
public class TestAttribute : Attribute
{
    public bool canSwitch;
    public TestAttribute(bool canSwitch)
    {
        this.canSwitch = canSwitch;
    }
}
