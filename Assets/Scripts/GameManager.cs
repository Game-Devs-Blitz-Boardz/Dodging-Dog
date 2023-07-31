using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    bool gameOver = false;
    ObstacleSpawner obstacleSpawner;

    void Awake() {
        instance = this;
        obstacleSpawner = FindObjectOfType<ObstacleSpawner>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GameOver() {
        gameOver = true;
        obstacleSpawner.StopSpawning();
    }
}
