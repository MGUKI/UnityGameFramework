using System;
using System.Collections.Generic;
using UnityEngine;

namespace MyFramework
{
    [CreateAssetMenu(fileName = "MyGameConfig",menuName = "GameConfig/设置")]
    public class GameConfig : ScriptableObject
    {
        public int num;
        public GameData _gameData;
        public List<GameData> _gameDatas;
    }
    [Serializable]
    public class GameData
    {
        public int ID;
        public String GamePath;
    }
}
