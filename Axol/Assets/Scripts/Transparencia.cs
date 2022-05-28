using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transparencia : MonoBehaviour
{
    public float tiempoAparecer = 5f;       // Velocidad de aparecer
    public float tiempoDesaparecer = 3f;    // Velocidad de desaparecer

    public bool startAlpha = true;
    public Image imagen;

    bool end = false;
    float alpha;

    void Start()
    {
        imagen = GetComponent<Image>();
        if (!startAlpha) { imagen.canvasRenderer.SetAlpha(0); }
        else { imagen.canvasRenderer.SetAlpha(0.99f); }
    }

    void Update()
    {
        alpha = imagen.canvasRenderer.GetAlpha();

        if (!end) { imagen.CrossFadeAlpha(1.0f, tiempoAparecer, false); end = true; }
        else if (alpha == 1.0f) { imagen.CrossFadeAlpha(0f, tiempoDesaparecer, false); }
        else if (alpha == 0) { imagen.gameObject.SetActive(false); }

        if (Input.GetMouseButtonDown(0))
        {
            imagen.gameObject.SetActive(false);
        }
    }
}