using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelsButtonManager : MonoBehaviour
{
    public void LoadLevel(int numLvl)
    {
        SceneManager.LoadScene(numLvl);
    }
}
