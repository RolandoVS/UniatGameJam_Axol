using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public int candles = 0;
    public int photos = 0;
    public ScriptReader scriptReader;

    void Start()
    {
        Debug.Log(scriptReader);
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Candle")) {
            candles++;
        }
        else if (other.gameObject.CompareTag("Photo")) { 
            photos++; 
            scriptReader.DialogTrigger(other);
        }
        //else if (other.gameObject.CompareTag("Tridimin")) { gameOver(); }
    }
}
