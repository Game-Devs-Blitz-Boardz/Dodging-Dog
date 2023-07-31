using UnityEngine;
using UnityEngine.SceneManagement;
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

    public void Restart() {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
}
