using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerStats : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI dashesRemainingText;
    Dash dashScript;
    private void Start()
    {
        dashScript = GetComponent<Dash>();
    }

    private void Update()
    {
        timeText.text = "time: "+ Time.timeSinceLevelLoad.ToString("f2");
        dashesRemainingText.text = dashScript.remainingDashes.ToString();
    }

    public void addScore(int value)
    {
        score += value;
        scoreText.text = "score: " + score;
    }
}
