using UnityEngine;
using System;

public class Banana : Fructs
{
    public static event Action EatBanana;
    [SerializeField] protected int pointsToGive;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        MyPlayerMovement player = collision.GetComponent<MyPlayerMovement>();
        if (player != null)
        {
            GivePoints();
            EatBanana?.Invoke();
            gameObject.SetActive(false);
        }
    }
    public override void GivePoints()
    {
        gameData.Score += pointsToGive;
        Debug.Log("10 points received");
        
    }
       
}
