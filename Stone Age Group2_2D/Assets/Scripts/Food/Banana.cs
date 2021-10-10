using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Fructs
{
    
    private void OnEnable()
    {
        ScoreCounter.GetPoints += GivePoints;
    }
    
    private void OnDisable()
    {
        ScoreCounter.GetPoints -= GivePoints;
    }
    public override void GivePoints()
    {
        gameData.Score += pointsToGive;
        
    }

    
}
