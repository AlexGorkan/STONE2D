using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerManagement : MonoBehaviour
{
    Image hungerBar;
    private float maxHunger = 1f;
    //private float hunger;
    [SerializeField] private float hungerDropSpeed = 0.001f;
    [SerializeField] private PlayerCondition playerCondition;

    private void Awake()
    {
        hungerBar = GetComponent<Image>();
    }

    void Start()
    {
        playerCondition.hunger = maxHunger;
        //hunger = maxHunger;
    }

   
    void Update()
    {
        hungerBar.fillAmount = playerCondition.hunger -= hungerDropSpeed;
    }
}
