using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fructs : MonoBehaviour
{
    public GameData gameData;
    [SerializeField] public int pointsToGive;
    public abstract void GivePoints();
}
