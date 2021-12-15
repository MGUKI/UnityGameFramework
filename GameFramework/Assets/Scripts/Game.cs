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
            EnemyEvent.Register(SetOverUI);
        }
        private void SetOverUI()
        {
            GameModel.a++;
            if (GameModel.a == 5)
            {
                //passUI.SetActive(true);
                GameOverEvent.Trigger();
            }
        }
        private void SetEnemyActive()
        {
            transform.Find("Enemy").gameObject.SetActive(true);
        }
        private void OnDisable()
        {
            GameStartEvent.UnRegister(SetEnemyActive);
            GameOverEvent.UnRegister(SetOverUI);
        }
    }
}

