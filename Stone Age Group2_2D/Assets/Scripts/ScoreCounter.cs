// https://docs.unity3d.com/ScriptReference/PlayerPrefs.html


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class ScoreCounter : MonoBehaviour
{
    public static event Action GetPoints;
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] private GameData gameData;
    

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
            CountScore();
            CheckWin();
            Destroy(collision.gameObject);

        }

    }

    private void CountScore()
    {
        scoreText.text = gameData.Score.ToString();
        CheckWin();
    }

    public void CheckWin()
    {
        if ((gameData.Score % 40) == 0)
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


