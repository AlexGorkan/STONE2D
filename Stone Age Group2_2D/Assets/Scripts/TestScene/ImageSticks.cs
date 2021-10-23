using ContainerEnums;
using UnityEngine;

public class ImageSticks : MonoBehaviour
{
    [SerializeField] private SticksTypes _sticksT;

    public SticksTypes SticksT { get => _sticksT; }
}
