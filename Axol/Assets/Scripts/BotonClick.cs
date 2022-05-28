using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonClick : MonoBehaviour
{
    public GameObject botonTutorial;
    public GameObject botonMundo1;
    public GameObject botonMundo2;
    public GameObject botonMundo3;
    public GameObject botonMundo4;
    public GameObject botonMundo5;

    public void CambiarNivel(string scene)
    {
        Debug.Log(scene);
        SceneManager.LoadScene(scene);
    }

    public void Salir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }

    public void MostrarMundos()
    {
        if (botonMundo1.activeSelf)
        {
            botonTutorial.SetActive(false);
            botonMundo1.SetActive(false);
            botonMundo2.SetActive(false);
            botonMundo3.SetActive(false);
            botonMundo4.SetActive(false);
            botonMundo5.SetActive(false);
        }
        else
        {
            botonTutorial.SetActive(true);
            botonMundo1.SetActive(true);
            botonMundo2.SetActive(true);
            botonMundo3.SetActive(true);
            botonMundo4.SetActive(true);
            botonMundo5.SetActive(true);
        }
    }
}