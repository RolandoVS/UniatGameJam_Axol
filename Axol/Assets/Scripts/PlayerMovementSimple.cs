using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSimple : MonoBehaviour
{
  public float speed = 1f;
  float hSpeed;
  float vSpeed;
  int candleCount, photoCount = 0;

  void Start()
  {
  }

  void Update()
  {
    hSpeed = Input.GetAxis("Horizontal") * speed;
    vSpeed = Input.GetAxis("Vertical") * speed;
  }

  // Dont forget Delta time
  void FixedUpdate()
  {
    gameObject.transform.Translate(hSpeed * Time.deltaTime, 0, vSpeed * Time.deltaTime);
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Candle") {
      Destroy(other.gameObject);
      candleCount++;
      Debug.Log($"Candle count: {candleCount}");
      if (candleCount == 3) {
        Debug.Log("GameOver");
      }
    }

    if (other.tag == "Photo") {
      Destroy(other.gameObject);
      photoCount++;
      Debug.Log($"Photo count: {photoCount}");
      if (photoCount == 5) {
        Debug.Log("GameOver");
      }
    }
  }
}
