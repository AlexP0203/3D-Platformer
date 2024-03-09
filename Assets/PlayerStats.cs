using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "Player Stats")]


public class PlayerStats : ScriptableObject
{
    
    View view;
    public float MaxHealth = 10;
    public float CurrentHealth = 10;
    public int Score = 0;
}
