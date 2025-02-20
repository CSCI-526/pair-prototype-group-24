using UnityEngine;

public class Exit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if collided with the player
        if(collision.CompareTag("Player"))
        {
            if(GameManager.instance.AllCoinsCollected())
            {
                // If all coins have been collected, complete the level
                GameManager.instance.LevelComplete();
            }
            else
            {
                Debug.Log("Not all coins have been collected!");
            }
        }
    }
}
