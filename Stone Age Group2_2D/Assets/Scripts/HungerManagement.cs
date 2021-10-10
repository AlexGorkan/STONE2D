using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerManagement : MonoBehaviour
{
    Image hungerBar;
    [SerializeField] private float hungerDropSpeed = 0.001f;
    [SerializeField] private PlayerCondition playerCondition;
    private float maxHunger = 1f;

    private void Awake()
    {
        hungerBar = GetComponent<Image>();
    }

    void Start()
    {
        playerCondition.hunger = maxHunger;
    }

   
    void Update()
    {
        if (hungerBar.fillAmount > 0f) 
        {
            hungerBar.fillAmount = playerCondition.hunger -= hungerDropSpeed;
        }
    }
}
