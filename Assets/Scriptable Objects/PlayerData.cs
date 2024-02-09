using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Players/Player", order = 10)]
public class PlayerData : ScriptableObject
{
    public float Health;
    public string Name;
    public int Lives;
}