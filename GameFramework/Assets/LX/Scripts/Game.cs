using UnityEngine;

namespace MyFramework
{
    public class Game : MonoBehaviour
    {
        private void Awake()
        {
            GameStartEvent.Register(SetEnemyActive);
            GameModel.count.OnValueChanged += SetOverUI;
        }
        private void SetOverUI(int CountValve)
        {
            if (CountValve == 5)
            {
                GameOverEvent.Trigger();
            }
        }
        private void SetEnemyActive()
        {
            transform.Find("Enemy").gameObject.SetActive(true);
        }
        private void OnDisable()
        {
            GameModel.count.OnValueChanged -= SetOverUI;
            GameStartEvent.UnRegister(SetEnemyActive);
        }
    }
}

