using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] public GameObject[] obstaclePrefabs; 
    public float minObstacleSpawnTime = 3f;
    public float maxObstacleSpawnTime = 5f;
    public float timeUntilObstacleSpawn; 
    public float obstacleSpeed = 5f; // Adjust this to control obstacle speed

    public void Update(){ 
        SpawnLoop(); 
    }

    public void SpawnLoop(){ 
        timeUntilObstacleSpawn -= Time.deltaTime; 

        if(timeUntilObstacleSpawn <= 0f){
            Spawn(); 
            timeUntilObstacleSpawn = Random.Range(minObstacleSpawnTime, maxObstacleSpawnTime); 
        }
    }

    public void Spawn(){ 
        GameObject obstacleToSpawn = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)]; 
        GameObject spawnedObstacle = Instantiate(obstacleToSpawn, transform.position, Quaternion.identity); 

        Rigidbody2D obstacleRB = spawnedObstacle.GetComponent<Rigidbody2D>(); 
        obstacleRB.velocity = Vector2.left * obstacleSpeed; 
    }
}


