using UnityEngine;

namespace MenuScene.Animations
{
    public class SceneTransitionAnimation : MonoBehaviour
    {
        [SerializeField] private Animator _transitionAnimator;

        public void ShowTransitionAnimation()
        {
            _transitionAnimator.SetTrigger("SceneTransitionIn");
        }
    }
}