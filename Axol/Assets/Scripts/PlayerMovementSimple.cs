using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSimple : MonoBehaviour
{
    public float speed = 1f;
    float hSpeed;
    float vSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        hSpeed = Input.GetAxis("Horizontal") * speed;
        vSpeed = Input.GetAxis("Vertical") * speed;
    }

    void FixedUpdate()
    {
        gameObject.transform.Translate(hSpeed, 0, vSpeed);
    }
}
