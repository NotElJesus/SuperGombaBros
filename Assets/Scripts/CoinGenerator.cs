using System.Collections;
using UnityEngine;

public class SpawnAndVanishCircles : MonoBehaviour
{
    // Define Prefab
    [SerializeField] public GameObject circlePrefab;
    public int numberOfCircles = 1;
    public float minCircleSpawnTime = 3f;
    public float maxCircleSpawnTime = 6f;

    public void Start()
    {
        // Create and Update circles randomly
        StartCoroutine(SpawnAndVanishLoop());
    }

    IEnumerator SpawnAndVanishLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minCircleSpawnTime, maxCircleSpawnTime));
            // Create number of Circles
            for (int i = 0; i < numberOfCircles; i++)
            {
                SpawnAndVanishCircle();
            }
        }
    }
    // Create and Delete circles
    public void SpawnAndVanishCircle()
    {
        Vector3 spawnPosition = GetRandomSpawnPosition();
        GameObject spawnedCircle = Instantiate(circlePrefab, spawnPosition, Quaternion.identity);

        // Set a random lifetime for the spawned circle
        float lifetime = Random.Range(2f, 3f);

        StartCoroutine(DestroyAfterTime(spawnedCircle, lifetime));
    }
    // Get Random Position
    private Vector3 GetRandomSpawnPosition()
    {
        float spawnX = Random.Range(-5f, 5f);
        float spawnY = Random.Range(-2f, 2f);

        return new Vector3(spawnX, spawnY, 0f);
    }

    // Destroy Circles
    IEnumerator DestroyAfterTime(GameObject obj, float lifetime)
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(obj);
    }
    
}
