using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject obstacle;
    public float spawnRate;
    public float maxXPos;

    void Start()
    {
        StartSpawning();
    }

    void Update()
    {
        
    }

    void Spawn() {
        float randomX = Random.Range(-maxXPos, maxXPos);

        Vector2 spawnPos = new Vector2(randomX, transform.position.y);

        Instantiate(obstacle, spawnPos, Quaternion.identity);
    }

    void StartSpawning() {
        InvokeRepeating("Spawn", 1f, spawnRate);
    }

    public void StopSpawning() {
        CancelInvoke("Spawn");
    }
}
