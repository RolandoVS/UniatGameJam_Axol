using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonnClick : MonoBehaviour
{
    public GameObject levelHolder;
    public Image credits;

    public void ChangeScene(string scene)
    {
        Debug.Log(scene);
        SceneManager.LoadScene(scene);
    }

    public void ToggleLevels()
    {
        if (levelHolder.activeSelf) { levelHolder.SetActive(false); }
        else { levelHolder.SetActive(true); }
    }

    public void Exit()
    {
        Debug.Log("Salir");
        Application.Quit();
    }

    public void ShowCredits()
    {
        credits.gameObject.SetActive(true);
    }

    public void HideCredits()
    {
        credits.gameObject.SetActive(false);
    }
}