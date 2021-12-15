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
            ViewModel.mOnEvent += OnCountChanged;
            
            number = transform.Find("Canvas/number").GetComponent<Text>();
            //UpdateView();
            
            transform.Find("Canvas/AddNumber").GetComponent<Button>().onClick.AddListener(() =>
            {
                //交互逻辑
                ViewModel.count++;
                //表现逻辑
                //UpdateView();
            });
            transform.Find("Canvas/SubNumber").GetComponent<Button>().onClick.AddListener(() =>
            {
                ViewModel.count--;
                //UpdateView();
            });
        }
        private void OnCountChanged(int newCount)
        {
            number.text = newCount.ToString();
        }
        void UpdateView()
        {
            number.text = ViewModel.count.ToString();
        }
        private void OnDisable()
        {
            ViewModel.mOnEvent -= OnCountChanged;
        }
    }
    public class ViewModel
    {
        private static int mCount;
        public static Action<int> mOnEvent;
        public static int count
        {
            get => mCount;
            set
            {
                if (value != mCount)
                {
                    mCount = value;
                    
                    mOnEvent?.Invoke(value);
                }
            }
        }
    }
}

