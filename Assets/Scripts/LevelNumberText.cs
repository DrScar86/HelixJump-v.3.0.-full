using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class LevelNumberText : MonoBehaviour
    {
        public Text Text;
        public Game Game;

        void Start()
        {
            Text.text = "Level " + (Game.LevelIndex + 1).ToString();
        }
    }
}