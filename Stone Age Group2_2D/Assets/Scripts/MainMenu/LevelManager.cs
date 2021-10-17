using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameData gameData;

    private void Start()
    {

       gameData.Score = gameData.GetData(gameData.scoreValueName);
       gameData.OpenLevels = gameData.GetData(gameData.openLevelsValueName);

        for (int i = 0; i < transform.childCount; i++)
        {
            if(i < gameData.OpenLevels)
            {
                transform.GetChild(i).GetComponent<Button>().interactable = true;
            }
            else
            {
                transform.GetChild(i).GetComponent<Button>().interactable = false;
            }
        }
    }

    private void OnApplicationQuit()
    {
        gameData.SaveData(gameData.scoreValueName, gameData.Score);
        gameData.SaveData(gameData.openLevelsValueName, gameData.OpenLevels);
    }

    public void Exit()
    {
        OnApplicationQuit();
    }
}
