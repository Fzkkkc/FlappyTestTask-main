using System;
using UnityEngine;
using UserInterface.LosePanelUI;
using Random = UnityEngine.Random;

namespace Obstacle
{
    public class ObstacleMovement : MonoBehaviour, IObserver
    {
        [SerializeField] private float _obstacleMovespeed;

        [SerializeField] private LosePanelObserver _losePanelObserver;
        
        private bool CanMoveOnLosePanel = true;
        private bool CanMoveOnStartPanel;

        private Vector2 _startPosition;

        private void Start()
        {
            _startPosition = transform.position;
            _losePanelObserver.AddObserver(this);
        }
        
        private void OnDisable()
        {
            _losePanelObserver.RemoveObserver(this);
        }

        private void FixedUpdate()
        {
            if (CanMoveOnLosePanel && CanMoveOnStartPanel)
            {
                transform.position = Vector2.Lerp(transform.position,
                    new Vector2(transform.position.x - _obstacleMovespeed, transform.position.y), 0.1f);
            }
        }

        public void MoveObstacleToTheStartPosition()
        {
            Vector2 newPosition = new Vector2(_startPosition.x, _startPosition.y + Random.Range(-2f, 2f));
            transform.position = newPosition;
        }
        
        public void StartMoving()
        {
            CanMoveOnStartPanel = true;
        }

        public void StopMoving()
        {
            CanMoveOnStartPanel = false;
        }
        
        
        public void OnInspectStarted()
        {
            CanMoveOnLosePanel = false;
        }

        public void OnInspectEnded()
        {
            CanMoveOnLosePanel = true;
        }
    }
}
