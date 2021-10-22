using UnityEngine;
using ContainerEnums;
using UnityEngine.UI;
using System;

[RequireComponent(typeof(Button))]
public class ButtonsCrystal : MonoBehaviour
{
    public static event Action<CrystalTypes> OnClickButton;

    [SerializeField] private CrystalTypes _crystalT;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(ClickBTN);
    }
        
    private void ClickBTN()
    {
        OnClickButton?.Invoke(_crystalT);
    }
}