using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class EndResults : MonoBehaviour
{
    public TextMeshProUGUI CollisionCount;
    private Collision collisionInfo;
    private int DeathCounter;
    public void Start()
    {
        CollisionCount.text = PlayerPrefs.GetInt("killCount", 0).ToString();
    }
    public void Update()
    {
        //DeathCount();
    }
    public void LoadLevelScene()
    {
        PlayerPrefs.SetInt("LoadLevel", 1);
    }
    public void DeathCount()
    {
        CollisionCount.SetText(DeathCounter.ToString("0"));
        Debug.Log(DeathCounter);
    }
    public void CoinCount()
    {

    }
    public void ScoreCount()
    {

    }
}
