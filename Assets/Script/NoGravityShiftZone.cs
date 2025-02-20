using UnityEngine;

public class NoGravityShiftZone : MonoBehaviour
{
    // Called when an object enters the trigger area
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Get the player's PlayerController script and disable gravity shifting
            PlayerController player = collision.GetComponent<PlayerController>();
            if (player != null)
                player.SetGravityShift(false);
        }
    }

    // Called when an object leaves the trigger area
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Get the player's PlayerController script and re-enable gravity shifting
            PlayerController player = collision.GetComponent<PlayerController>();
            if (player != null)
                player.SetGravityShift(true);
        }
    }
}

