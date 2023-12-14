using UnityEngine;
using UnityEngine.UI;

public class scoreNew : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text highScoreText;

    private float currentScore = 0f;
    private float highScore = 0f;
    private string highScoreKey = "HighScore";

    void Start()
    {
        // Load the high score from PlayerPrefs
        highScore = PlayerPrefs.GetFloat(highScoreKey, 0f);
        UpdateHighScoreText();
    }

    void FixedUpdate()
    {
        if (PlayerCollision.gameScoreCol > 0)
        {
            currentScore = PlayerCollision.gameScoreCol;
            scoreText.text = "Score: " + currentScore.ToString("0");

            // Check for a new high score
            if (currentScore > highScore)
            {
                highScore = currentScore;
                UpdateHighScoreText();

                // Save the new high score to PlayerPrefs
                PlayerPrefs.SetFloat(highScoreKey, highScore);
                PlayerPrefs.Save();
            }
        }
        else
        {
            scoreText.text = "You Fell Out Of The Platform";
        }
    }

    void UpdateHighScoreText()
    {
        highScoreText.text = "High Score: " + highScore.ToString("0");
    }
}