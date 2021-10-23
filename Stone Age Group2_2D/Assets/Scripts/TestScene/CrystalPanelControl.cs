using DG.Tweening;
using UnityEngine;

public class CrystalPanelControl : MonoBehaviour
{
    [SerializeField] private Transform _crystalPanel;

    private Tween _tween;

    private bool IsVisible = true;

    public void OpenPanel()
    {
        if (IsVisible == false)
        {
            _tween = _crystalPanel.DOMove(new Vector3(_crystalPanel.position.x, _crystalPanel.position.y + 20), 2f, true);
            IsVisible = true;
        }
    }

    public void ClosePanel()
    {
        if (IsVisible == true)
        {
            _tween = _crystalPanel.DOMove(new Vector3(_crystalPanel.position.x, _crystalPanel.position.y - 20), 2f, true);
            IsVisible = false;
        }
    }

    private void OnDisable()
    {
        _tween.Kill();
    }
}
