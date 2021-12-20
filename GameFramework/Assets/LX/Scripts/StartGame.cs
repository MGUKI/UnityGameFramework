using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MyFramework
{
    public class StartGame : MonoBehaviour
    {
        void Start()
        {
            transform.Find("BtnStart").GetComponent<Button>().onClick.AddListener(() =>
            {
                gameObject.SetActive(false);
                GameStartEvent.Trigger();
            });
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}

