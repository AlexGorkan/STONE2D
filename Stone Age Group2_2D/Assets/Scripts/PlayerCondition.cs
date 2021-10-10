using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerCondition", menuName = "ScriptableObjects/PlayerCondition", order = 1)]
public class PlayerCondition : ScriptableObject
{
    public float hunger;
    public int hearths;
       
    public void Awake()
    {
        hunger = 1f;
        hearths = 3;
    }
       
}
