using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MyFramework
{
    public class Enemy : MonoBehaviour
    {
        

        private void OnMouseDown()
        {
            Destroy(gameObject);
            EnemyEvent.Trigger();
        }
    }
}

