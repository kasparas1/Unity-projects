using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Fader SceneFader;
    public Button[] LevelButtons;
    public GameObject[] LevelText;
    public GameObject[] LockImage;
    public GameObject MainMenu;
    public GameObject Levels;

    void Start()
    {
        int LoadLevel = PlayerPrefs.GetInt("LoadLevel", 0);
        int reachedLevel = PlayerPrefs.GetInt("reachedLevel", 1);
        for (int i = 0; i < LevelButtons.Length; i++)
            if(i+1 > reachedLevel)
            {
                LevelButtons[i].interactable = false;
                LevelText[i].SetActive(false);
                LockImage[i].SetActive(true);
            }
        if(LoadLevel == 1)
        {
            MainMenu.SetActive(false);
            Levels.SetActive(true);
            PlayerPrefs.SetInt("LoadLevel", 0);
        }
        Debug.Log(LoadLevel);
    }
    public void SelectLevel(string levelName)
    {
        SceneFader.FadeTo(levelName);
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void LevelButtonIsPressed()
    {
        
    }
}
