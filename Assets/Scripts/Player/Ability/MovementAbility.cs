using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAbility : MonoBehaviour
{
    [SerializeField] private int speedIncrease;
    [SerializeField] private PlayerMovement movement;
    [SerializeField] private AbilitySystem abilitySystem;

    public void OnSpeedUpgrade()
    {
        movement.OnSpeedUpgrade(speedIncrease);
        abilitySystem.onAbilitySelect?.Invoke();
    }
}
