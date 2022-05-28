using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeAway : MonoBehaviour
{
    public float showTime = 5f;       // Velocidad de aparecer
    public float fadeTime = 3f;    // Velocidad de desaparecer

    public bool startAlpha = true;
    public Image image;

    bool end = false;
    float alpha;

    void Start()
    {
        image = GetComponent<Image>();
        if (!startAlpha) { image.canvasRenderer.SetAlpha(0); }
        else { image.canvasRenderer.SetAlpha(0.99f); }
    }

    void Update()
    {
        alpha = image.canvasRenderer.GetAlpha();

        if (!end) { image.CrossFadeAlpha(1.0f, showTime, false); end = true; }
        else if (alpha == 1.0f) { image.CrossFadeAlpha(0f, fadeTime, false); }
        else if (alpha == 0) { image.gameObject.SetActive(false); }

        if (Input.GetMouseButtonDown(0))
        {
            image.gameObject.SetActive(false);
        }
    }
}