using System;
using Player;
using TMPro;
using UnityEngine;

namespace UserInterface.LosePanelUI
{
    public class CurrentPlayerScoreTextUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _currentPlayerScoreText;
        [SerializeField] private PlayerScore _playerScore;
        [SerializeField] private bool _isInLosePanel;
        
        private void OnValidate()
        {
            _currentPlayerScoreText ??= GetComponent<TextMeshProUGUI>();
            _playerScore ??= FindObjectOfType<PlayerScore>();
        }
        
        public void UpdatePlayerCurrentScore()
        {
            var prefix = "";

            if (_isInLosePanel)
                prefix = "+";
            
            _currentPlayerScoreText.text = $"{prefix}{_playerScore.CurrentPlayerScore.ToString()}";
        }
    }
}