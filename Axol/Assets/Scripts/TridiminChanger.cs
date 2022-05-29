using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TridiminChanger : MonoBehaviour
{
    public bool killer = true;

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
            else { other.transform.Rotate(0.0f, -90.0f, 0.0f); }
            this.gameObject.SetActive(false);
        }
    }
}
