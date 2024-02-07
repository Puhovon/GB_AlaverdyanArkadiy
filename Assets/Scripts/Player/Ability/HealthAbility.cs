using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAbility : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private int healthIncrease;

    public void OnHealthUpgrade()
    {
        health.UpgradeHealth(healthIncrease);
    }

    public void OnFullHeal()
    {
        health.FullHeal();
    }
}
