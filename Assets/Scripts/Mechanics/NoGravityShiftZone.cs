using UnityEngine;
using Platformer.Gameplay;

namespace Platformer.Mechanics
{
    public class NoGravityShiftZone : MonoBehaviour
    {
    // Called when an object enters the trigger area
        private void OnTriggerEnter2D(Collider2D collider)
        {
        if (collider.CompareTag("Player"))
        {
            // Get the player's PlayerController script and disable gravity shifting
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
                p.SetGravityShift(false);
        }
        }

    // Called when an object leaves the trigger area
        private void OnTriggerExit2D(Collider2D collider)
        {
        if (collider.CompareTag("Player"))
        {
            // Get the player's PlayerController script and re-enable gravity shifting
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
                p.SetGravityShift(true);
        }
        }
    }
}
