using DG.Tweening;
using UnityEngine;

public class StickPanelControl : MonoBehaviour
{
    [SerializeField] private Transform _sticksPanel;

    private Tween _tween;

    private bool IsVisible = true;

    public void OpenPanel()
    {
        if (IsVisible == false)
        {
            IsVisible = true;
            _sticksPanel.DOMove(new Vector3(_sticksPanel.position.x, _sticksPanel.position.y + 20), 1f, true);
            
        }
    }

    public void ClosePanel()
    {
        if (IsVisible == true)
        {
            IsVisible = false;
            _sticksPanel.DOMove(new Vector3(_sticksPanel.position.x, _sticksPanel.position.y - 20), 1f, true);
            
        }
    }

    private void OnDisable()
    {
        _tween.Kill();
    }
}
