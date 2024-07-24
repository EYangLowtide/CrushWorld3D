using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Add this line
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public static int scoreCount;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the score
        scoreCount = 0;
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        // Update the score display
        UpdateScoreText();

        // Check if the score has reached 100
        if (scoreCount >= 100)
        {
            LoadGameOverScene();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "EXPLOSIONS: " + Mathf.RoundToInt(scoreCount);
    }

    void LoadGameOverScene()
    {
        // Ensure the time scale is reset (if your game has any time manipulation)
        Time.timeScale = 1;

        // Load the "GameOver" scene (replace "GameOver" with the actual name of your game over scene)
        SceneManager.LoadScene("GameOver");
    }
}
