using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public int candles = 0;
    public int photos = 0;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Candle")) { candles++; }
        else if (other.gameObject.CompareTag("Photo")) { photos++; }
        //else if (other.gameObject.CompareTag("Tridimin")) { gameOver(); }
    }
}
