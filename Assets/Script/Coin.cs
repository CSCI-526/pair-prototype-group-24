using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if collided with the player
        if(collision.CompareTag("Player"))
        {
            // Notify the GameManager that a coin has been collected
            GameManager.instance.CoinCollected();
            // Destroy the coin object
            Destroy(gameObject);
        }
    }
}
