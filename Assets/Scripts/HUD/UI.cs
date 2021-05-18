using TMPro;
using UnityEngine;

namespace HUD
{
    [RequireComponent(typeof(TMP_Text))]
    public class UI : MonoBehaviour
    {
        private static TMP_Text _scoreUI;

        public static int LevelScore { get; set; }

        private void Start()
        {
            _scoreUI = GetComponent<TMP_Text>();
        }

        public static void ShowScoreUI()
        {
            _scoreUI.text = LevelScore.ToString();
        }
    }
}
