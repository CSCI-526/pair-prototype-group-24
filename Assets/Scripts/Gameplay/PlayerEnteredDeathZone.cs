using UnityEngine;
using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when a player enters a trigger with a DeathZone component.
    /// </summary>
    /// <typeparam name="PlayerEnteredDeathZone"></typeparam>
    public class PlayerEnteredDeathZone : Simulation.Event<PlayerEnteredDeathZone>
    {
        public DeathZone deathzone;

        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            var ev = Simulation.Schedule<PlayerDeath>(0);
            Debug.Log("PlayerDeath event details: " + ev);
            Debug.Log("PlayerDeath simulation scheduled");
        }
    }
}