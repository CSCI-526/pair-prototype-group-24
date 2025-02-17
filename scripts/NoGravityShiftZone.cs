using UnityEngine;
using Platformer.Mechanics;

public class NoGravityShiftZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider belongs to the player
        var player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            // Disable gravity shifting and reset gravity to the default downward direction
            player.allowGravityShift = false;
            player.ShiftGravity(Vector2.down);
            Debug.Log("Entered no-gravity-shift zone, gravity reset to down");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        var player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            // Re-enable gravity shifting
            player.allowGravityShift = true;
            Debug.Log("Exited no-gravity-shift zone, gravity shifting restored");
        }
    }
}

