using System;
using UnityEngine;

namespace Obstacles
{
    public class SinusoidalObstacle : MonoBehaviour
    {
        [SerializeField] private float frequency = 1;
        [SerializeField] private float amplitude = 2;
        private float _startY;

        private void Start()
        {
            _startY = transform.position.y;
        }

        private void Update()
        {
            var newY = _startY + Mathf.Sin(Time.time * frequency) * amplitude;
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
    }
}
