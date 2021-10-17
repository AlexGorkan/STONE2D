using UnityEngine;

public class Banana : Fructs
{
        
    public override void GiveScore()
    {
        gameData.Score += scoreToGive;
        gameObject.SetActive(false);
    }
}