using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject obstacle;
    public float spawnRate;
    public float maxXPos;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Spawn();
        }
    }

    void Spawn() {
        float randomX = Random.Range(-maxXPos, maxXPos);

        Vector2 spawnPos = new Vector2(randomX, transform.position.y);

        Instantiate(obstacle, spawnPos, Quaternion.identity);
    }
}
