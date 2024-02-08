using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ScriptableObjects
{
    void Start()
    {
        Debug.Log("Player name is " + Name);
        Debug.Log("Player health is " + Health);
        Debug.Log("Remaining lives: " + Lives);
    }

    void Update()
    {
     

    }
}