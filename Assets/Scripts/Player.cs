using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{ 
    public PlayerData playerData;

    public void Start()
    {
        
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Test");
        }

        Debug.Log("Player health is " + playerData.Health);
        Debug.Log("Player name is " + playerData.Name);
        Debug.Log("Remaining lives:" + playerData.Lives);
    }
}