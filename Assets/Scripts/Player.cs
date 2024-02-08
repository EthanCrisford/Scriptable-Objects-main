using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : ScriptableObjects
{
    public void Start()
    {
        
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Test");
        }

        Debug.Log("Player health is " + Health);
        Debug.Log("Player name is " + Name);
        Debug.Log("Remaining lives:" + Lives);
    }
}