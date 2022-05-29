using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialWall : MonoBehaviour
{
    private Renderer myRender;
    public bool monsterAttack = true;
    public int id = 0;

    float fadeSpeed = 0.1f;
    float timer = 0.05f;
    bool active = false;

    void Start()
    {
        myRender = gameObject.GetComponent<Renderer>();
    }

    void Update()
    {
        if (active)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                timer = 0.05f;
                Color color = myRender.material.color;
                color.a -= fadeSpeed;
                myRender.material.color = color;
                if (color.a < 0) { this.gameObject.SetActive(false); }
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!active && other.gameObject.CompareTag("Player"))
        {
            active = true;
            if (monsterAttack)
            {
                GameEvents.current.ButtonPress(id);
            }
        }
    }
}
