using System;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;
        [SerializeField] private float rotationSpeed;
        [SerializeField] private PlayerSphere rightSphere, leftSphere;
        public Action PlayerCollidedWithObstacle;

        private void Awake()
        {
            rightSphere.Collided += OnSphereCollided;
            leftSphere.Collided += OnSphereCollided;
        }

        private void Update()
        {
            UpdateRotation();
            MoveForward();
        }

        private void MoveForward()
        {
            transform.position += transform.forward * (Time.deltaTime * movementSpeed);
        }

        private void UpdateRotation()
        {
            var horizontal = Input.GetAxis("Horizontal");
            transform.Rotate(transform.forward, horizontal * Time.deltaTime * rotationSpeed);
        }

        private void OnSphereCollided()
        {
            PlayerCollidedWithObstacle?.Invoke();
        }

        private void OnDestroy()
        {
            rightSphere.Collided -= OnSphereCollided;
            leftSphere.Collided -= OnSphereCollided;
        }
    }
}