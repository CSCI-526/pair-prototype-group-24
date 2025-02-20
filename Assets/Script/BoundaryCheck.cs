using UnityEngine;
using UnityEngine.SceneManagement;

public class BoundaryCheck : MonoBehaviour
{
    // Define the minimum and maximum boundaries of the game area in world coordinates (adjustable in the Inspector)
    public Vector2 minBoundary = new Vector2(-10, -10);
    public Vector2 maxBoundary = new Vector2(10, 10);

    void Update()
    {
        // Get the player's current position (world coordinates)
        Vector3 pos = transform.position;

        // If the player goes out of the preset range, reload the current scene
        if (pos.x < minBoundary.x || pos.x > maxBoundary.x ||
            pos.y < minBoundary.y || pos.y > maxBoundary.y)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}