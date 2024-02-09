using General.GamePlay;
using Player.Ability;
using Player.General;
using UnityEngine;

namespace General
{
    public class Bootstrap : MonoBehaviour
    {
        [Header("Player Settings")] [SerializeField]
        private PlayerManager playerManager;

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
}