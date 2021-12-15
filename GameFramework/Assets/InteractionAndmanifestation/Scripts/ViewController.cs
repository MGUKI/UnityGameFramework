using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MyFramework
{
    public class ViewController : MonoBehaviour
    {
        private Text number;
        void Start()
        {
            number = transform.Find("Canvas/number").GetComponent<Text>();
            UpdateView();
            transform.Find("Canvas/AddNumber").GetComponent<Button>().onClick.AddListener(() =>
            {
                GameModel.count++;
                UpdateView();
            });
            transform.Find("Canvas/SubNumber").GetComponent<Button>().onClick.AddListener(() =>
            {
                GameModel.count--;
                UpdateView();
            });
        }
        void UpdateView()
        {
            number.text = GameModel.count.ToString();
        }
    }
}

