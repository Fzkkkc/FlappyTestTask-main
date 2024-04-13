using Player;
using UnityEngine;
using UserInterface;

namespace System
{
    public class GameInstance : Singleton<GameInstance>
    {
        [SerializeField] private UIController _uiController;
        [SerializeField] private PlayerScore _playerScore;
        
        public static UIController UIController => Default._uiController;
        public static PlayerScore PlayerScore => Default._playerScore;
        
        protected override void Awake()
        {
            base.Awake();
        }
    }
}