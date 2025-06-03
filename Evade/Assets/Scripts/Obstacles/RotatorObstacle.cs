using UnityEngine;

namespace Obstacles
{
    public class RotatorObstacle : Obstacle
    {
        [SerializeField] private float rotationSpeed;

        protected override void Move()
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
