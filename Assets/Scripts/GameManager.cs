using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    bool gameOver = false;
    ObstacleSpawner obstacleSpawner;
    int score = 0;

    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;

    void Awake() {
        instance = this;
        obstacleSpawner = FindObjectOfType<ObstacleSpawner>();
    }

    public void GameOver() {
        gameOver = true;
        obstacleSpawner.StopSpawning();
        gameOverPanel.SetActive(true);
    }

    public void IncrementScore() {
        if (!gameOver) {
            score++;
            scoreText.text = score.ToString();
            Debug.Log(score);
        }
    }
}
