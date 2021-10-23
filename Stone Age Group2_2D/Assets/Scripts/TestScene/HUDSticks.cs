using UnityEngine;
using ContainerEnums;

public class HUDSticks : MonoBehaviour
{
    [SerializeField] private ImageSticks[] _imageSticks;

    private void Awake()
    {
        HideAllImages();
    }
    private void OnEnable()
    {
        ButtonsSticks.OnClickButtonStick += SetStickImage;
    }

    private void OnDisable()
    {
        ButtonsSticks.OnClickButtonStick -= SetStickImage;
    }

    private void SetStickImage(SticksTypes sticksTypes)
    {
        HideAllImages();
        for (int i = 0; i < _imageSticks.Length; i++)
        {
            if (sticksTypes == _imageSticks[i].SticksT)
            {
                _imageSticks[i].gameObject.SetActive(true);
            }
        }
    }
    private void HideAllImages()
    {
        for (int i = 0; i < _imageSticks.Length; i++)
        {
            _imageSticks[i].gameObject.SetActive(false);
        }
    }
}
