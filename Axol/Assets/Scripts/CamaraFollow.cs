using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;
    public float suavizado = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        Vector3 posicionDeseada = target.transform.position + offset;
        Vector3 posicionSuavizada = Vector3.Lerp(transform.position, posicionDeseada, Time.deltaTime * suavizado);
        transform.position = posicionDeseada;
        transform.LookAt(target.transform);
        transform.rotation = target.transform.rotation;
    }
}
