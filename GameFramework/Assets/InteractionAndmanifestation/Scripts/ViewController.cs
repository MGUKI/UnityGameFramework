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
            OnCountChangedEvent.Register(OnCountChanged);
            
            number = transform.Find("Canvas/number").GetComponent<Text>();

            transform.Find("Canvas/AddNumber").GetComponent<Button>().onClick.AddListener(() =>
            {
                //交互逻辑
                ViewModel.count++;
            });
            transform.Find("Canvas/SubNumber").GetComponent<Button>().onClick.AddListener(() =>
            {
                //交互逻辑
                ViewModel.count--;
            });
        }
        private void OnCountChanged()
        {
            number.text = ViewModel.count.ToString();
        }
        private void OnDisable()
        {
            OnCountChangedEvent.UnRegister(OnCountChanged);
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
                    
                    //mOnEvent?.Invoke(value);
                    OnCountChangedEvent.Trigger();
                }
            }
        }
    }

    public class OnCountChangedEvent : Event<OnCountChangedEvent>
    {
        
    }
}

