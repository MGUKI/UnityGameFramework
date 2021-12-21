using System;
using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    void Start()
    {
        Debug.Log(TestSingleton.Instance.testTxt);
        Debug.Log(GameRoot.Instance.testTxt);
    }
}
public class TestSingleton : Singleton<TestSingleton>
{
    public String testTxt = "TestSingleton";
}
