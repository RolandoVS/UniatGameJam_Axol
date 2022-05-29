using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action<int> press;
    public void ButtonPress(int id)
    {
        if (press != null)
        {
            press(id);
        }
    }

    public event Action<int> lift;
    public void ButtonLift(int id)
    {
        if (lift != null)
        {
            lift(id);
        }
    }
}
