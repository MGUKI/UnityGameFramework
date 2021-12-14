using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Entrust
{
    public class Enemy : MonoBehaviour
    {
        public GameObject passUI;
        private static int a;

        private void OnMouseDown()
        {
            Destroy(gameObject);
            a++;
            if (a == 5)
            {
                //passUI.SetActive(true);
                GameOverEvent.Trigger();
            }
        }
    }
}

