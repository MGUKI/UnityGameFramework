using System;
using UnityEngine;
using UnityEngine.UI;

namespace MyFramework
{
    public class ViewController : MonoBehaviour
    {
        private Text number;
        void Start()
        {
            //订阅方法
            CounterModel.count.OnValueChanged += OnCountChanged;
            
            number = transform.Find("Canvas/number").GetComponent<Text>();

            OnCountChanged(CounterModel.count.Valve);

            transform.Find("Canvas/AddNumber").GetComponent<Button>().onClick.AddListener(() =>
            {
                //交互逻辑
                CounterModel.count.Valve++;
            });
            transform.Find("Canvas/SubNumber").GetComponent<Button>().onClick.AddListener(() =>
            {
                //交互逻辑
                CounterModel.count.Valve--;
            });
        }
        private void OnCountChanged(int count)
        {
            number.text = count.ToString();
        }
        private void OnDisable()
        {
            //取消订阅
            CounterModel.count.OnValueChanged -= OnCountChanged;
        }
    }
    public class CounterModel
    {
        public static BindableProperty<int> count = new BindableProperty<int>() {Valve = 0};
    }
}

