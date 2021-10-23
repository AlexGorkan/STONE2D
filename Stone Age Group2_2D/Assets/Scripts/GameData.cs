using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData", order = 1)]
public class GameData : ScriptableObject
{
    [SerializeField] private int score;
    [SerializeField] private int openLevels;

    public string scoreValueName = "Score";
    public string openLevelsValueName = "OpenLevels";

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
        SaveData(scoreValueName, Score);
        SaveData(openLevelsValueName, OpenLevels);
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
