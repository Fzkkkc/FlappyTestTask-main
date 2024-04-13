using System.Collections;
using SoundPreferences;
using UnityEngine;

namespace UserInterface.SettingsPopupUI
{
    public class PopupOpenButton : MonoBehaviour
    {
        [SerializeField] private AntiClickPanel _antiClickPanel;
        
        [SerializeField] private Animator _popupAnimator;
        public bool IsPopupOpened = false;

        public void OpenPopupSetting()
        {
            _popupAnimator.SetTrigger("PopupSettingsClicked");
            
            StartCoroutine(StopTimeCoroutine());
            
            if (!IsPopupOpened)
            {
                _antiClickPanel.ShowAntiClickPanel();
                AudioManager.Instance.PlaySfx("ButtonClicked");
            }
            
            IsPopupOpened = true;
        }
        
        private IEnumerator StopTimeCoroutine()
        {
            yield return new WaitForSecondsRealtime(0.4f);
            Time.timeScale = 0f;
        }
    }
}