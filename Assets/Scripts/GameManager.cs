using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    bool gameOver = false;
    ObstacleSpawner obstacleSpawner;
    int score = 0;

    public TextMeshProUGUI scoreText;

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
            scoreText.text = score.ToString();
            Debug.Log(score);
        }
    }
}
