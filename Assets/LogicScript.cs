using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button button;

    void Start()
    {
        gameOverText.text = "";
        button.gameObject.SetActive(false);
    }

    [ContextMenu("Add Score")]
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void TriggerGameOver()
    {
        gameOverText.text = "Game Over";
        button.gameObject.SetActive(true);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
