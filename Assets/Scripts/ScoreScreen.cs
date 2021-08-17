using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ScoreScreen : MonoBehaviour
{
    public PlayerStats playerStats;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;
    public HighScores highScores;
    public void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        timeText.text = playerStats.timeText.text;
        scoreText.text = playerStats.scoreText.text;
        string level = SceneManager.GetActiveScene().name;
        int[] currentHighScores = highScores.highScores1;
        if (level == "Level1")
        {
            currentHighScores = highScores.highScores1;
        }
        else if(level == "Level2")
        {
            currentHighScores = highScores.highScores2;
        }
        else if (level == "Level3")
        {
            currentHighScores = highScores.highScores3;
        }
        else if (level == "Level4")
        {
            currentHighScores = highScores.highScores4;
        }
        currentHighScores[5] = playerStats.score;
        for(int i = currentHighScores.Length-1; i > 0; i--)
        {
            if(currentHighScores[i] > currentHighScores[i - 1])
            {
                (currentHighScores[i], currentHighScores[i - 1]) = (currentHighScores[i - 1], currentHighScores[i]);
            }
        }
        for (int i = 0; i < currentHighScores.Length-1; i++)
        {
            highScoreText.text += (i+1) + " Score: " + currentHighScores[i] + "\n";
        }
    }
    public void LevelSelectButton()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
