// https://docs.unity3d.com/ScriptReference/PlayerPrefs.html


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] private GameData gameData;
    

    private void Start()
    {
        scoreText.text = gameData.Score.ToString();
    }

    private void OnEnable()
    {
        MyPlayerMovement.GetPoints += CountScore;
    }

    private void OnDisable()
    {
        MyPlayerMovement.GetPoints -= CountScore;
    }
    private void CountScore()
    {
        scoreText.text = gameData.Score.ToString();
        //CheckWin();
    }

    public void CheckWin()
    {
        if ((gameData.Score % 30) == 0)
        {
            if (SceneManager.GetActiveScene().buildIndex == gameData.OpenLevels)
            {
                gameData.OpenLevels++;   
            }
            gameData.SaveData();
            Debug.Log("YOU WIN!!!");
            SceneManager.LoadScene(0);
        }

    }

}


