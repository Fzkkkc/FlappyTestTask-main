using System.Collections;
using SceneManagment;
using SoundPreferences;
using UnityEngine;

namespace UserInterface.LosePanelUI
{
    public class LosePanelRestartButton : MonoBehaviour
    {
        [SerializeField] private LosePanel _losePanel;
        [SerializeField] private LosePanelObserver _losePanelObserver;
        
        private RestartLevel _restartLevel = new RestartLevel();
        
        private IEnumerator RestartLevelCoroutine()
        {
            _losePanel.CloseLosePanel();

            yield return new WaitForSecondsRealtime(0.3f);
            
            _restartLevel.RestartScene();
            _losePanelObserver.NotifyLosePanelEnded();
        }

        public void RestartLevel()
        {
            AudioManager.Instance.PlaySfx("ButtonClicked");
            StartCoroutine(RestartLevelCoroutine());
        }
    }
}