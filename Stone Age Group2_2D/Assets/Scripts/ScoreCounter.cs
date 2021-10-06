// https://docs.unity3d.com/ScriptReference/PlayerPrefs.html


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] private GameData gameData;
    public static event Action GetPoints;

    private void Start()
    {
        scoreText.text = gameData.Score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.layer == 7)
        //{
        //    CountScore();
        //    Destroy(collision.gameObject);
        //}
        Fructs fructs = collision.GetComponent<Fructs>();
        if (fructs != null)
        {
            GetPoints?.Invoke();
            CheckWin();
            Destroy(collision.gameObject);

        }

    }


    //private void CountScore()
    //{
    //    gameData.Score += 10;
    //    scoreText.text = gameData.Score.ToString();
    //    CheckWin();
    //}

    public void CheckWin()
    {
        if ((gameData.Score % 240) == 0)
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


