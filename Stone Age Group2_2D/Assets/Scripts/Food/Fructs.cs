using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Fructs : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    public GameData gameData;
    [SerializeField] public int pointsToGive;
    public abstract void GivePoints();
}
