using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFramework
{
    public class GameModel
    {
        public static BindableProperty<int> count = new BindableProperty<int>(){Valve = 0};
    }
}

