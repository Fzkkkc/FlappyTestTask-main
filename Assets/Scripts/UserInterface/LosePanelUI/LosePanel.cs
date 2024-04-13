using System;
using UnityEngine;

namespace UserInterface.LosePanelUI
{
    public class LosePanel : MonoBehaviour
    {
        [SerializeField] private Animator _losePanelAnimator;

        [SerializeField] private AntiClickPanel _antiClickPanel;
        [SerializeField] private CurrentPlayerScoreTextUI _currentPlayerScoreTextUI;
        
        public bool IsLosePanelOpen = false;
        
        public void ShowLosePanel()
        {
            _antiClickPanel.ShowAntiClickPanel();
            _currentPlayerScoreTextUI.UpdatePlayerCurrentScore();
            IsLosePanelOpen = true;
            _losePanelAnimator.SetTrigger("ShowLosePanel");
        }

        public void CloseLosePanel()
        {
            _antiClickPanel.FullAntiClickPanelAnimation();
            IsLosePanelOpen = false;
            _losePanelAnimator.SetTrigger("CloseLosePanel");
            GameInstance.PlayerScore.ResetCurrentPlayerScore();
        }
    }
}