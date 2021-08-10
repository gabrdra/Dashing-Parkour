using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    public GameObject howToPlayPanel;
    private bool howToPlayPanelStatus = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void StartButton()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void HowToPlayButton()
    {
        howToPlayPanelStatus = !(howToPlayPanelStatus);
        howToPlayPanel.SetActive(howToPlayPanelStatus);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
