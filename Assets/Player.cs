using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MW.Saving;

public class Player : MonoBehaviour, ISaveable
{
    public float health = 10;

    public object CaptureState()
    {
        return health;
    }

    public void RestoreState(object state)
    {
        health = (float)state;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            health++;
        }
    }
}
