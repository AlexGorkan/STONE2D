using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData", order = 1)]
public class GameData : ScriptableObject
{
    public string scoreValueName = "Score";
    public string openLevelsValueName = "OpenLevels";

    [SerializeField] private int score;
    [SerializeField] private int openLevels;
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }
    public int OpenLevels
    {
        get
        {
            if (openLevels < 1)
                return 1;
            else
                return openLevels;
        }
        set
        {
            openLevels = value;
        }
    }



    private void Awake()
    {
        // gameData.DeleteKeyData(openLevelsValueName);


        if (!PlayerPrefs.HasKey(scoreValueName))
        {
            SaveData(scoreValueName, Score);
        }
        if (!PlayerPrefs.HasKey(openLevelsValueName))
        {
            SaveData(openLevelsValueName, OpenLevels);
        }
    }



    public void SaveData(string KeyName, int Value)
    {
        PlayerPrefs.SetInt(KeyName, Value);
    }
    public void SaveData()
    {
        SaveData(scoreValueName, Score);
        SaveData(openLevelsValueName, OpenLevels);
    }
    public int GetData(string KeyName)
    {
        return PlayerPrefs.GetInt(KeyName);
    }

    public void DeleteKeyData(string KeyName)
    {
        PlayerPrefs.DeleteKey(KeyName);
    }
}
