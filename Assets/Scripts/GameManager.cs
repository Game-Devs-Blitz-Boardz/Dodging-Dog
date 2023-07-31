using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    bool gameOver = false;
    ObstacleSpawner obstacleSpawner;
    int score = 0;

    void Awake() {
        instance = this;
        obstacleSpawner = FindObjectOfType<ObstacleSpawner>();
    }

    public void GameOver() {
        gameOver = true;
        obstacleSpawner.StopSpawning();
    }

    public void IncrementScore() {
        if (!gameOver) {
            score++;
            Debug.Log(score);
        }
    }
}
