using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entrust
{
    public class Game : MonoBehaviour
    {
        private void Awake()
        {
            GameStartEvent.Register(SetEnemyActive);
        }
        private void SetEnemyActive()
        {
            transform.Find("Enemy").gameObject.SetActive(true);
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
            GameStartEvent.UnRegister(SetEnemyActive);
        }
    }
}

