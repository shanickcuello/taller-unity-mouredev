using UnityEngine;

namespace Obstacles
{
    public class ObstacleSpawner : MonoBehaviour
    {
        [SerializeField] private Transform player;
        [SerializeField] private GameObject obstaclePrefab;
        [SerializeField] private float spawnInterval = 3f;
        [SerializeField] private float spawnDistanceFromPlayer = 20;

        private float _spawnTimer;

        private void Update()
        {
            _spawnTimer += Time.deltaTime;
            if (!(_spawnTimer >= spawnInterval)) return;

            var angle = Random.Range(0f, Mathf.PI * 2);
            var offsetX = Mathf.Cos(angle) * 2f;
            var offsetY = Mathf.Sin(angle) * 2f;

            var spawnPosition = player.position + new Vector3(offsetX, offsetY, spawnDistanceFromPlayer);

            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
            _spawnTimer = 0f;
        }
    }
}