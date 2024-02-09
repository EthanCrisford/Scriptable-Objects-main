using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public PlayerData playerData;

    public void Start()
    {

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Plus)) 
        {
            playerData.Health += 1;
        }

        if (Input.GetKeyDown(KeyCode.Minus))
        {
            playerData.Health -= 1;
        }
    }
}