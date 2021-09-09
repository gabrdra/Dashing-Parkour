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
    private int currentLevel;
    public void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        int currentLevel = 1;
        SaveStructure save = SaveSystem.LoadGame();
        if(save != null)
        {
            highScores.highScores1 = save.highScores1;
            highScores.highScores2 = save.highScores2;
            highScores.highScores3 = save.highScores3;
            highScores.highScores4 = save.highScores4;
        }
        timeText.text = playerStats.timeText.text;
        scoreText.text = playerStats.scoreText.text;
        string level = SceneManager.GetActiveScene().name;
        int[] currentHighScores = highScores.highScores1;
        if (level == "Level1")
        {
            currentHighScores = highScores.highScores1;
            currentLevel = 1;
        }
        else if(level == "Level2")
        {
            currentHighScores = highScores.highScores2;
            currentLevel = 2;
        }
        else if (level == "Level3")
        {
            currentHighScores = highScores.highScores3;
            currentLevel = 3;
        }
        else if (level == "Level4")
        {
            currentHighScores = highScores.highScores4;
            currentLevel = 4;
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
        SaveStructure saveStructure = new SaveStructure(currentLevel, highScores);
        SaveSystem.SaveGame(saveStructure);
    }
    public void LevelSelectButton()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
