using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void StartButton()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
