using System;
using UnityEngine;

namespace Player
{
    public class PlayerSphere : MonoBehaviour
    {
        public event Action Collided;

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log($"I {gameObject.name} collided with {other.gameObject.name}");
            Collided?.Invoke();
        }    
    }
}
