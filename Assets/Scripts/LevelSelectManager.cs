using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelSelectManager : MonoBehaviour
{
    [SerializeField] GameObject level1buttonGameObject;
    [SerializeField] GameObject level2buttonGameObject;
    [SerializeField] GameObject level3buttonGameObject;
    [SerializeField] GameObject level4buttonGameObject;
    int highestLevelAvaliable = 1;
    void Start()
    {
        SaveStructure save = SaveSystem.LoadGame();
        Button level1button = level1buttonGameObject.GetComponent<Button>();
        Button level2button = level2buttonGameObject.GetComponent<Button>();
        Button level3button = level3buttonGameObject.GetComponent<Button>();
        Button level4button = level4buttonGameObject.GetComponent<Button>();
        if (save != null)
        {
            highestLevelAvaliable = save.highestLevelCompleted + 1;
        }
        switch (highestLevelAvaliable)
        {
            case 1:
                level1button.enabled = true;
                level2button.enabled = false;
                level2buttonGameObject.GetComponent<Image>().color = Color.red; 
                level3button.enabled = false;
                level3buttonGameObject.GetComponent<Image>().color = Color.red;
                level4button.enabled = false;
                level4buttonGameObject.GetComponent<Image>().color = Color.red;
                break;
            case 2:
                level1button.enabled = true;
                level2button.enabled = true;
                level3button.enabled = false;
                level3buttonGameObject.GetComponent<Image>().color = Color.red;
                level4button.enabled = false;
                level4buttonGameObject.GetComponent<Image>().color = Color.red;
                break;
            case 3:
                level1button.enabled = true;
                level2button.enabled = true;
                level3button.enabled = true;
                level4button.enabled = false;
                level4buttonGameObject.GetComponent<Image>().color = Color.red;
                break;
            case 4:
                level1button.enabled = true;
                level2button.enabled = true;
                level3button.enabled = true;
                level4button.enabled = true;
                break;
            case 5:
                level1button.enabled = true;
                level2button.enabled = true;
                level3button.enabled = true;
                level4button.enabled = true;
                break;
        }
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

