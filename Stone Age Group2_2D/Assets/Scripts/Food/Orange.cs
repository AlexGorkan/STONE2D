using UnityEngine;
using System;

public class Orange : Fructs
{
    public static event Action EatOrange;
    [SerializeField] protected int pointsToGive;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        MyPlayerMovement player = collision.GetComponent<MyPlayerMovement>();
        if (player != null)
        {
            GivePoints();
            EatOrange?.Invoke();
            gameObject.SetActive(false);
        }
    }

    public override void GivePoints()
    {
        gameData.Score += pointsToGive;
    }


}
