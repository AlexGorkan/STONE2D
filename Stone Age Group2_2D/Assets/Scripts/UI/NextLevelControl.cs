using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelControl : MonoBehaviour
{
    [SerializeField] private Image _blackScreen;

    private Tween _tween;

    protected bool isPaused = false;

    public void OnNextLevelButtonClick()
    {
        if (isPaused == false)
        {
            _blackScreen.DOColor(new Color(0f, 0f, 0f, 0f), 0.1f);
            _blackScreen.DOFade(1, 4f).OnComplete(() =>
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                OnNextLevelStart();
                
            });
            isPaused = true;
        }

    }

    public void OnNextLevelStart()
    {
        _blackScreen.DOColor(new Color(1f, 1f, 1f, 1f), 0.1f);
        _blackScreen.DOFade(0, 4f);
        isPaused = false;
    }


    private void OnDisable()
    {
        _tween.Kill();
    }
}
