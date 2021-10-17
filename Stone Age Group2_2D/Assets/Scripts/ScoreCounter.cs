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
        MyPlayerMovement.OnPickUpFood += CountScore;
    }

    private void OnDisable()
    {
        MyPlayerMovement.OnPickUpFood -= CountScore;
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


