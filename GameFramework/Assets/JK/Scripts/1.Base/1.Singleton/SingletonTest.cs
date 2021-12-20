using System;
using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    void Start()
    {
        Debug.Log(TestSingleton.Instance.txt);
    }
}
public class TestSingleton : Singleton<TestSingleton>
{
    public String txt = "555";
}
