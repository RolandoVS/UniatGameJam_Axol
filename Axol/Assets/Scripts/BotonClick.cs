using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonClick : MonoBehaviour
{
    public GameObject mundosHolder;
    public Image creditos;

    public void CambiarNivel(string scene)
    {
        Debug.Log(scene);
        SceneManager.LoadScene(scene);
    }

    public void MostrarMundos()
    {
        if (mundosHolder.activeSelf) { mundosHolder.SetActive(false); }
        else { mundosHolder.SetActive(true); }
    }

    public void Salir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }

    public void MostrarCreditos()
    {
        creditos.gameObject.SetActive(true);
    }

    public void CerrarCreditos()
    {
        creditos.gameObject.SetActive(false);
    }
}