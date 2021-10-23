using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelControl : MonoBehaviour
{
    [SerializeField] private Image _blackScreen;

    private Tween _tween;

    protected bool isPaused = false;

    private void Start()
    {
        _blackScreen = GetComponent<Image>();
    }
    public void OnNextLevelButtonClick()
    {
        if (isPaused == false)
        {
            _blackScreen.DOColor(new Color(0f, 0f, 0f, 0f), 0.1f);
            _blackScreen.DOFade(1, 4f).OnComplete(() =>
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                OnNextLevelStart();
                Time.timeScale = 0;
            });
            isPaused = true;
        }

    }

    public void OnNextLevelStart()
    {
        _blackScreen.DOColor(new Color(1f, 1f, 1f, 1f), 0.1f);
        _blackScreen.DOFade(0, 4f).OnComplete(() => Time.timeScale = 1);

        isPaused = false;
    }


    private void OnDisable()
    {
        _tween.Kill();
    }
}
