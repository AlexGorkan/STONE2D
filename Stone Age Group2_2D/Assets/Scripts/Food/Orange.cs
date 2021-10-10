using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : Fructs
{
    [SerializeField] protected int pointsToGive;
    private void OnEnable()
    {
        MyPlayerMovement.GetPoints += GivePoints;
    }

    private void OnDisable()
    {
        MyPlayerMovement.GetPoints -= GivePoints;
    }
    public override void GivePoints()
    {
        gameData.Score += pointsToGive;
        
    }


}
