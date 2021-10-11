// https://docs.unity3d.com/ScriptReference/PlayerPrefs.html


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    [SerializeField] public Text scoreText;
    [SerializeField] private GameData gameData;
    
    private void Start()
    {
        scoreText.text = gameData.Score.ToString();
    }

    private void OnEnable()
    {
        Banana.EatBanana += CountScore;
        Orange.EatOrange += CountScore;

    }

    private void OnDisable()
    {
        Banana.EatBanana -= CountScore;
        Orange.EatOrange -= CountScore;
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


