using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TridiminTrot : MonoBehaviour
{
    public float speed = 0.5f;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        gameObject.transform.Translate(0, 0, speed);
    }
}
