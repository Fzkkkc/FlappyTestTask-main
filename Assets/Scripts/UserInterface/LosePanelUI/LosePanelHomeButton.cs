using System.Collections;
using SceneManagment;
using SoundPreferences;
using UnityEngine;

namespace UserInterface.LosePanelUI
{
    public class LosePanelHomeButton : MonoBehaviour
    {
        [SerializeField] private LosePanel _losePanel;
        [SerializeField] private LosePanelObserver _losePanelObserver;
        
        private NextScene _nextScene = new NextScene();
        
        private IEnumerator ToMainMenuCoroutine()
        {
            _losePanel.CloseLosePanel();

            yield return new WaitForSeconds(0.4f);
            
            _nextScene.LoadNextScene();
            _losePanelObserver.NotifyLosePanelEnded();
        }

        public void ToMainMenu()
        {
            AudioManager.Instance.PlaySfx("ButtonClicked");
            StartCoroutine(ToMainMenuCoroutine());
        }
    }
}