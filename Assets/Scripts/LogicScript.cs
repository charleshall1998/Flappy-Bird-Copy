using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource pointAudioSource;
    public AudioSource gameOverAudioSource;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString();
        pointAudioSource.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void EndGame()
    {
        gameOverScreen.SetActive(true);
        gameOverAudioSource.Play();
    }
}
