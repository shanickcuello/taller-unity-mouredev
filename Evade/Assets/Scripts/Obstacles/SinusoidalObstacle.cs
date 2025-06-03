using System;
using UnityEngine;

namespace Obstacles
{
    public class SinusoidalObstacle : Obstacle
    {
        [SerializeField] private float frequency = 1;
        [SerializeField] private float amplitude = 2;
        private float _startY;

        private void Start()
        {
            _startY = transform.position.y;
        }
        
        protected override void Move()
        {
            var newY = _startY + Mathf.Sin(Time.time * frequency) * amplitude;
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
    }
}
