using UnityEngine;

namespace Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] Transform target;
        [SerializeField] private Vector3 offset;

        private void Update()
        {
            transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime);
        }
    }
}