using UnityEngine;

namespace GamePreference
{
    public class GameStart : MonoBehaviour
    {
        [SerializeField] private Animator _startGameAnimator;
        
        private void Start()
        {
            StartGame();
        }
        
        private void StartGame()
        {
            _startGameAnimator.SetTrigger("GameTransitionIn");
        }
    }
}
