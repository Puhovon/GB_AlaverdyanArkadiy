using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAbility : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private int healthIncrease;
    [SerializeField] private AbilitySystem abilitySystem;


    public void OnHealthUpgrade()
    {
        health.UpgradeHealth(healthIncrease);
        transform.gameObject.SetActive(false);
        abilitySystem.onAbilitySelect?.Invoke();
    }

    public void OnFullHeal()
    {
        health.FullHeal();
        transform.gameObject.SetActive(false);
        abilitySystem.onAbilitySelect?.Invoke();

    }
}
