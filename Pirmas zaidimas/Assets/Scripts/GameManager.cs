using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool GameOver = false;
    public float RestartDelay = 1f;
    public GameObject LevelCompleteScreen;
    public GameObject Player;
    public GameObject DeathScreen;
    public Renderer Ground;
    public Renderer PlayerRender;
    public Color GroundColour;
    public Color PlayerColor;
    public void LevelComplete()
    {
        Invoke("PlayerOff", RestartDelay);
        LevelCompleteScreen.SetActive(true);
    }
    void PlayerOff() 
    {
        Player.SetActive(false);
    }
    public void EndGame()
    {
        //Object = GetComponent<Renderer>();
        if(GameOver == false)
        {
            GameOver = true;
            Ground.material.color = GroundColour;
            PlayerRender.material.color = PlayerColor;
            Debug.Log("zaidimas baigtas");
            Invoke("ActivateDeathScreen", RestartDelay);
        }
    }
    public void ActivateDeathScreen()
    {
        DeathScreen.SetActive(true);
    }
}
