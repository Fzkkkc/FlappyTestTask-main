using System.Collections;
using MenuScene.Animations;
using SceneManagment;
using SoundPreferences;
using UnityEngine;

namespace MenuScene
{
    public class LoadGameplayScene : MonoBehaviour
    {
        [SerializeField] private SceneTransitionAnimation _sceneTransition;
        [SerializeField] private MainGroupDisappearAnimation _mainGroupDisappearAnimation;
        
        private NextScene _nextScene = new NextScene();
        
        private IEnumerator NextLevelCoroutine()
        {
            _sceneTransition.ShowTransitionAnimation();
            _mainGroupDisappearAnimation.MainGroupOutAnimation();
            
            yield return new WaitForSeconds(1f);
            _nextScene.LoadNextScene();
        }

        public void LoadGameplayLevel()
        {
            AudioManager.Instance.PlaySfx("ButtonClicked");
            StartCoroutine(NextLevelCoroutine());
        }
    }
}
