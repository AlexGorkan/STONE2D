using UnityEngine;

public abstract class Fructs : MonoBehaviour
{

    [SerializeField] protected GameData gameData;

    [SerializeField] protected int scoreToGive;

    public abstract void GiveScore();
      
}
