using Fusion;
using UnityEngine;

public class PlayerSpawner : SimulationBehaviour, IPlayerJoined {
    public GameObject PlayerPrefab;
    
    public void PlayerJoined(PlayerRef player) {
        if (player == Runner.LocalPlayer) {
            var rnd = new System.Random();   
            int x = rnd.Next(-3,0);
            int z = rnd.Next(11,13);
            Runner.Spawn(PlayerPrefab, new Vector3(x,1,z), Quaternion.identity, player);
        }
    }
}