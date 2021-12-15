using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFramework
{
    public class UIEvent : MonoBehaviour
    {
        private void Awake()
        {
            GameOverEvent.Register(SetGameOverActive);
        }

        private void SetGameOverActive()
        {
            transform.Find("Canvas/GameOver").gameObject.SetActive(true);
        }
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnDisable()
        {
            GameOverEvent.UnRegister(SetGameOverActive);
        }
    }
}

