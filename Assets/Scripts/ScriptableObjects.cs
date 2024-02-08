using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Players/Player", order = 10)]
public class ScriptableObjects : ScriptableObject
{
    public float Health;
    public string Name;
    public int Lives;
    
    public void Awake()
    {
        GameObject.DontDestroyOnLoad(this);
    }
}