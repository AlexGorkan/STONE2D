using UnityEngine;
using ContainerEnums;

public class HUDController : MonoBehaviour
{
    [SerializeField] private ImageCrystals[] _imageCrystals;

    private void Awake()
    {
        HideAllImages();
    }
    private void OnEnable()
    {
        ButtonsCrystal.OnClickButton += SetImage;
    }

    private void OnDisable()
    {
        ButtonsCrystal.OnClickButton -= SetImage;
    }

    private void SetImage(CrystalTypes crystalTypes)
    {
        HideAllImages();
        for (int i = 0; i < _imageCrystals.Length; i++)
        {
            if (crystalTypes == _imageCrystals[i].CrystalT)
            {
                _imageCrystals[i].gameObject.SetActive(true);
            }
        }
    }
    private void HideAllImages()
    {
        for (int i = 0; i < _imageCrystals.Length; i++)
        {
            _imageCrystals[i].gameObject.SetActive(false);
        }
    }
}
