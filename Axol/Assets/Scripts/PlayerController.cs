using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private float axisMovementX;
    private float axisMovementY;
    private float axisMovementZ;
    private Vector2 movementVector;
    private Rigidbody varRigidBody;

    /* al poner /* se inicia un comentario en párrafo
    private int playerLives = 10;
    private int myPlayerIntegrer = 20;
    private GameObject lettuce;
     Start is called before the first frame update
    y se termina al poner */
    void Start()
    {
        varRigidBody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement3d = new Vector3(axisMovementX, 0.0f, axisMovementY);
        varRigidBody.AddForce(movement3d * speed);
    }

    void OnMove(InputValue movementValue)
    {
        movementVector = movementValue.Get<Vector2>();
        axisMovementX = movementVector.x;
        axisMovementY = movementVector.y;
    }


    // This function will only work with gameobject that
    // have the box collider added an have checked the option
    // is_trigger.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
        }
    }
}