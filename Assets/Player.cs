using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MW.Saving;
using System;

public class Player : MonoBehaviour, ISaveable
{
    [Serializable]
    public class PlayerData
    {
        public float health;
        public SerializableVector3 pos;

    }

    public float health;

    public object CaptureState()
    {
        PlayerData playerData = new PlayerData();
        playerData.health = health;
        playerData.pos = new SerializableVector3(transform.position);

        return playerData;
    }

    public void RestoreState(object state)
    {

        PlayerData playerData = (PlayerData)state;
        transform.position = playerData.pos.ToVector();
        health = playerData.health;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            health++;
            transform.Translate(new Vector3(1, 0, 0));
        }
    }
}
