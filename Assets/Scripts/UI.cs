using System;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreUI;

    private void Start()
    {
        ShowScoreUI();
    }

    private void ShowScoreUI()
    {
        scoreUI.text = 0.ToString("D6");
    }
}
