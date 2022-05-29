using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TridiminChanger : MonoBehaviour
{
    public bool killer = true;
    public bool die = true;
    public bool left = true;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tridimin"))
        {
            if (killer) { other.gameObject.SetActive(false); }
            else if (left) { other.transform.Rotate(0.0f, -90.0f, 0.0f); }
            else { other.transform.Rotate(0.0f, 90.0f, 0.0f); }
            if (die) { this.gameObject.SetActive(false); }
        }
    }
}
