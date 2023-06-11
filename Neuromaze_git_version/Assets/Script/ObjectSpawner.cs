using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;  // The prefab of the object to spawn
    public float spawnInterval = 1f; // The interval between spawns in seconds
    public int spawnNumber = 5; // The number of objects to spawn
    public Vector3 spawnRotation = Vector3.zero; // The rotation of the spawned objects

    private void Start()
    {
        // Start spawning objects with the given interval
        InvokeRepeating("SpawnObject", spawnInterval, spawnInterval);
    }

    private void SpawnObject()
    {
        // Instantiate the object prefab
        GameObject spawnedObject = Instantiate(objectPrefab, transform.position, Quaternion.Euler(spawnRotation));

        // Decrease the count of objects to spawn
        spawnNumber--;

        // If all objects have been spawned, cancel the spawning
        if (spawnNumber <= 0)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
