using UnityEngine;

namespace Obstacle
{
    public class ObstacleCollision : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Obstacle") && other.TryGetComponent(out ObstacleMovement obstacleMovement))
            {
                obstacleMovement.MoveObstacleToTheStartPosition();
            }
        }
    }
}