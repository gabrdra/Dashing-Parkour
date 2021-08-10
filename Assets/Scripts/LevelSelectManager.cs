using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectManager : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LevelSelectButton(int level)
    {
        SceneManager.LoadScene("Level" + level);
    }
}

