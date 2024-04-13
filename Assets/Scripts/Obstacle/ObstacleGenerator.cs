using System.Collections.Generic;
using UnityEngine;
using UserInterface.LosePanelUI;

namespace Obstacle
{
    public class ObstacleGenerator : MonoBehaviour
    {
        [SerializeField] private int _generationRate;

        [SerializeField] private LosePanel _losePanel;

        [SerializeField] private List<ObstacleMovement> _obstacleGameObjects;
        
        private int _timer;
        private int _currentObstacleIndex = 0;

        private void FixedUpdate()
        {
            if (_currentObstacleIndex < 2)
            {
                IncreaseTimer();

                if (_timer >= _generationRate && !_losePanel.IsLosePanelOpen)
                {
                    _timer = 0;
                    ActivateNextObstacle();
                }
            }
        }

        private void IncreaseTimer()
        {
            _timer++;
        }
        
        private void ActivateNextObstacle()
        {
            if (_currentObstacleIndex < _obstacleGameObjects.Count)
            {
                _obstacleGameObjects[_currentObstacleIndex].StartMoving();
                _currentObstacleIndex++;
            }
        }
    }
}
