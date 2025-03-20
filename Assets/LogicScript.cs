using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    
    public Button playAgainButton;
    public Button quitButton;

    void Start()
    {
        playAgainButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
    }

    [ContextMenu("Add Score")]
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void TriggerGameOver()
    {
        gameOverText.gameObject.SetActive(true);
        playAgainButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
