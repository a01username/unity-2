using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHP : MonoBehaviour
{
    public int health = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Generate a random health change between -10 and 10
            int randHealthChange = Random.Range(-10, 10);
            ChangeHealth(randHealthChange);
        }
    }

    public void ChangeHealth(int value)
    {
        // Update the player's health, clamped within the specified range
        health += value;
        health = Mathf.Clamp(health, 0, 100);
        Debug.Log(health);
    }
}
