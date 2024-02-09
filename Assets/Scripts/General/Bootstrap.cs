using System;
using General.GamePlay;
using Player;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private PlayerManager playerManager;
    [SerializeField] private Level levelManager;
    [SerializeField] private UIController ui;
    [SerializeField] private AbilitySystem abilitySystem;
    
    
    private void Start()
    {
        playerManager.Initialize();
        levelManager.Initialize();
        ui.Initialize();
        abilitySystem.Initialize();
    }
}
