using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialWall : MonoBehaviour
{
    public float fadeSpeed = 1;
    public bool monsterAttack = true;
    bool active = false;

    Color color;

    void Start()
    {
        color = this.GetComponent<MeshRenderer>().material.color;
    }

    void Update()
    {
        if (active)
        {
            color.a -= Time.deltaTime * fadeSpeed;
            if (color.a < 0) { this.gameObject.SetActive(false); }
            this.GetComponent<MeshRenderer>().material.color = color;
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!active && other.gameObject.CompareTag("Player"))
        {
            active = true;
            if (monsterAttack)
            {
                //var++;
            }
        }
    }
}
