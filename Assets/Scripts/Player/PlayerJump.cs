using System;
using UnityEngine;

namespace Player
{
    public class PlayerJump : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _birdRigidbody;
        
        private float _jumpForce = 5f;
        
        public void BirdJump()
        {
            _birdRigidbody.velocity = new Vector2(0, _jumpForce);
        }

        public void StopBird()
        {
            _birdRigidbody.freezeRotation = true;
            _birdRigidbody.constraints = (RigidbodyConstraints2D) RigidbodyConstraints.FreezeAll;
        }
    }
}
