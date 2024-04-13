using System;
using SoundPreferences;
using UnityEngine;
using UserInterface.LosePanelUI;
using UserInterface.SettingsPopupUI;

namespace Player
{
    public class PlayerInputInteraction : MonoBehaviour
    {
        [SerializeField] private PlayerJump _playerJump;
        [SerializeField] private LosePanel _losePanel;
        [SerializeField] private PopupOpenButton _popupSettings;
        
        private void Update()
        {
            JumpInput();
        }

        private void JumpInput()
        {
            if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                if (!_losePanel.IsLosePanelOpen && !_popupSettings.IsPopupOpened)
                {
                    _playerJump.BirdJump();
                    AudioManager.Instance.PlaySfx("FlappyJump");
                }
            }
        }
    }
}