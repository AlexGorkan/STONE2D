using UnityEngine;

public class Orange : Fructs
{
          
    public override void GiveScore()
    {
        gameData.Score += scoreToGive;
        gameObject.SetActive(false);
    }
}
