using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform[] spawnPoints;  // Array of spawn points

    private void Start()
    {
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        // Randomly select a spawn point from the spawnPoints array
        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

        // Move the player to the selected spawn point
        transform.position = spawnPoint.position;
        transform.rotation = spawnPoint.rotation;
    }
}
