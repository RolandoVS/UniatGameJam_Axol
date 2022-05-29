using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TridiminControler : MonoBehaviour
{
    public GameObject tridimin;

    float[] posX = {1f, 3f, -5f, -7f, 5f};
    float[] posZ = {-1f, 5f, 7f, 1f, -5f};

    private void OnEnable()
    {
        GameEvents.current.press += TridiminAttack;
    }

    private void OnDisable()
    {
        GameEvents.current.press -= TridiminAttack;
    }

    private void TridiminAttack(int id)
    {
        tridimin.transform.position = new Vector3(posX[id], 0, posZ[id]);
        if (id > 0 && id != 3) { tridimin.transform.Rotate(0.0f, -90.0f, 0.0f); }
        tridimin.gameObject.SetActive(true);
    }
}
