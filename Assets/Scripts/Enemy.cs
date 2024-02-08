using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : ScriptableObjects
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Plus)) 
        {
            Health += 1;
        }

        if (Input.GetKeyDown(KeyCode.Minus))
        {
            Health -= 1;
        }
    }
}