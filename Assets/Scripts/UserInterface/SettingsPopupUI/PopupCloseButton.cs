using SoundPreferences;
using UnityEngine;

namespace UserInterface.SettingsPopupUI
{
    public class PopupCloseButton : MonoBehaviour
    {
        [SerializeField] private Animator _popupAnimator;
        
        [SerializeField] private AntiClickPanel _antiClickPanel;
        [SerializeField] private PopupOpenButton _popupOpenButton;
        
        public void ClosePopupSetting()
        {
            Time.timeScale = 1f;
            
            if (_popupOpenButton.IsPopupOpened)
            {
                _popupAnimator.SetTrigger("PopupCloseButtonClicked");
                AudioManager.Instance.PlaySfx("ButtonClicked");
                _antiClickPanel.CloseAntiClickPanel();
            }
            
            _popupOpenButton.IsPopupOpened = false;
        }
    }
}