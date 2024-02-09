using General.Entities;
using UnityEngine;

namespace Player.Ability
{
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
}