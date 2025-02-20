using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collider is the player
        if (collision.CompareTag("Player"))
        {
            // Reload the current scene, restarting the level
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

