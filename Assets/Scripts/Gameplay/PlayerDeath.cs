using System.Collections;
using System.Collections.Generic;
using Platformer.Core;
using Platformer.Model;
using UnityEngine;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the player has died.
    /// </summary>
    /// <typeparam name="PlayerDeath"></typeparam>
    public class PlayerDeath : Simulation.Event<PlayerDeath>
    {
        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            Debug.Log("PlayerDeath event executing...");
            var player = model.player;
            Debug.Log("Assigned player: " + player);
            Debug.Log("Checking player object: " + player);
            Debug.Log("Checking player.health: " + (player.health != null ? "Exists" : "NULL"));
            Debug.Log("player.health.IsAlive: " + player.health.IsAlive);
            if (player.health.IsAlive)
            {
                Debug.Log("Calling player.health.Die() now...");
                player.health.Die();
                Debug.Log("player.health.Die() call finished");
                model.virtualCamera.m_Follow = null;
                model.virtualCamera.m_LookAt = null;
                // player.collider.enabled = false;
                player.controlEnabled = false;

                if (player.audioSource && player.ouchAudio)
                    player.audioSource.PlayOneShot(player.ouchAudio);
                player.animator.SetTrigger("hurt");
                player.animator.SetBool("dead", true);
                Simulation.Schedule<PlayerSpawn>(2);
                Debug.Log("PlayerSpawn simulation scheduled");
            }
        }
    }
}