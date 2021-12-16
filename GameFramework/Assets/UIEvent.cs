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
        private void OnDisable()
        {
            GameOverEvent.UnRegister(SetGameOverActive);
        }
    }
}

