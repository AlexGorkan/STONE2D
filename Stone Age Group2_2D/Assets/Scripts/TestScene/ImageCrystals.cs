using ContainerEnums;
using UnityEngine;

public class ImageCrystals : MonoBehaviour
{
    [SerializeField] private CrystalTypes _crystalT;

    public CrystalTypes CrystalT { get => _crystalT; }
}
