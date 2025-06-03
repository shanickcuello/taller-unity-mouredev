using System;
using UnityEngine;

namespace Obstacles
{
    public abstract class Obstacle : MonoBehaviour
    {
        protected abstract void Move();

        private void Update()
        {
            Move();
        }
    }
}
