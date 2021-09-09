using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveStructure
{
    public int highestLevelCompleted = 0;
    public int[] highScores1;
    public int[] highScores2;
    public int[] highScores3;
    public int[] highScores4;
    
    public SaveStructure(SaveStructure saveStructure)
    {
        if (saveStructure.highestLevelCompleted > highestLevelCompleted)
        {
            highestLevelCompleted = saveStructure.highestLevelCompleted;
        }
        highScores1 = saveStructure.highScores1;
        highScores2 = saveStructure.highScores2;
        highScores3 = saveStructure.highScores3;
        highScores4 = saveStructure.highScores4;
    }
    public SaveStructure(int currentLevel, HighScores highScores)
    {
        if(currentLevel > highestLevelCompleted)
        {
            highestLevelCompleted = currentLevel;
        }
        highScores1 = highScores.highScores1;
        highScores2 = highScores.highScores2;
        highScores3 = highScores.highScores3;
        highScores4 = highScores.highScores4;
    }
}
