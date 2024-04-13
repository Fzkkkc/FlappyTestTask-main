using UnityEngine;

namespace MenuScene.Animations
{
    public class MainGroupDisappearAnimation : MonoBehaviour
    {
        [SerializeField] private Animator _mainGroupAnimator;

        public void MainGroupOutAnimation()
        {
            _mainGroupAnimator.SetTrigger("MainGroupDisappear");
        }
    }
}