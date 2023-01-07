using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    public void DeathCounter(int deaths)
    {
        deaths++;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainMenu(string mainMenu)
    {
        SceneManager.LoadScene(mainMenu);
    }
}
