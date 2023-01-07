using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class Fader : MonoBehaviour
{
    public Image image;
    public AnimationCurve Curve;

    void Start()
    {
        StartCoroutine(FadeIn());
    }
    public void FadeTo(string scene)
    {
        StartCoroutine(FadeOut(scene));
    }
    IEnumerator FadeIn()
    {
        float time = 1f;
        while (time > 0f)
        {
            time -= Time.deltaTime;
            float alpha = Curve.Evaluate(time);
            image.color = new Color(0f, 0f, 0f, alpha);
            yield return 0;
        }
    }
    IEnumerator FadeOut(string scene)
    {
        float time = 0f;
        while (time < 1f)
        {
            time += Time.deltaTime;
            float alpha = Curve.Evaluate(time);
            image.color = new Color(0f, 0f, 0f, alpha);
            yield return 0;
        }
        SceneManager.LoadScene(scene);
    }
}
