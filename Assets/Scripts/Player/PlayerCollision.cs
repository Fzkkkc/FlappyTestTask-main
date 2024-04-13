using System;
using SoundPreferences;
using UnityEngine;
using UserInterface;
using UserInterface.LosePanelUI;

namespace Player
{
    public class PlayerCollision : MonoBehaviour
    {
        [SerializeField] private LosePanel _losePanel;
        [SerializeField] private LosePanelObserver _losePanelObserver;
        [SerializeField] private PlayerJump _playerJump;
        [SerializeField] private PlayerScore _playerScore;

        private int _soundsUsedCounter;
        
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("ScoreTrigger"))
            {
                _playerScore.IncreaseCurrentPlayerScore();
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            PlayLoseSound();
            _losePanelObserver.NotifyLosePanelStarted();
            _losePanel.ShowLosePanel();
            
            if (other.gameObject.CompareTag("Ground"))
            {
                _playerJump.StopBird();
            }
        }

        private void PlayLoseSound()
        {
            _soundsUsedCounter++;
            if (_soundsUsedCounter == 1)
            {
                AudioManager.Instance.PlaySfx("LoseSound");
            }
        }
    }
}