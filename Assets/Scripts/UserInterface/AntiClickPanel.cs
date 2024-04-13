using UnityEngine;

namespace UserInterface
{
    public class AntiClickPanel : MonoBehaviour
    {
        [SerializeField] private Animator _antiClickPanelAnimator;

        public void ShowAntiClickPanel()
        {
            _antiClickPanelAnimator.SetTrigger("ShowAntiClickPanel");
        }
        
        public void CloseAntiClickPanel()
        {
            _antiClickPanelAnimator.SetTrigger("CloseAntiClickPanel");
        }

        public void FullAntiClickPanelAnimation()
        {
            _antiClickPanelAnimator.SetTrigger("FullAntiClickPanel");
        }
    }
}