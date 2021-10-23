using UnityEngine;
using ContainerEnums;
using UnityEngine.UI;
using System;

[RequireComponent(typeof(Button))]

public class ButtonsSticks : MonoBehaviour
{
    public static event Action<SticksTypes> OnClickButtonStick;

    [SerializeField] private SticksTypes _sticksT;

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
        OnClickButtonStick?.Invoke(_sticksT);
    }
}
