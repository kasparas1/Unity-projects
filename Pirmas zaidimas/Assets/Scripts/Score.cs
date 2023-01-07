using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public TextMeshProUGUI ScoreText;

    void Update()
    {
        ScoreText.SetText(Player.position.z.ToString("0"));
    }
}
