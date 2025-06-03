using System;
using Player;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameFlow
{
    public class GameFlowController : MonoBehaviour
    {
        [SerializeField] PlayerController playerController;

        private void Awake()
        {
            playerController.PlayerCollidedWithObstacle += PlayerDied;
        }

        private void PlayerDied()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        private void OnDestroy()
        {
            playerController.PlayerCollidedWithObstacle -= PlayerDied;
        }
    }
}
