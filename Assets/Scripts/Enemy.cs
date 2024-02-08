using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : ScriptableObjects
{
    public void Start()
    {

    }
    public void Update()
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