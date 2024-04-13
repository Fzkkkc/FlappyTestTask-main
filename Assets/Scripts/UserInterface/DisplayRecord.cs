using System;
using TMPro;
using UnityEngine;

namespace UserInterface
{
    public class DisplayRecord : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _scoreText;

        private void OnValidate()
        {
            _scoreText ??= GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            UpdateScoreText();
        }

        private void UpdateScoreText()
        {
            _scoreText.text = $"{PlayerPrefs.GetInt("RecordPlayerScore", 0)}".ToString();
        }
    }
}