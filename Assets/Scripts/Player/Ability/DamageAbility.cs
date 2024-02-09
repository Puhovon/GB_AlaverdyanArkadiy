using Player.General;
using UnityEngine;

namespace Player.Ability
{
    public class DamageAbility : MonoBehaviour
    {
        [SerializeField] private int damageIncrease;
        [SerializeField] private PlayerAttack damage;
        [SerializeField] private AbilitySystem abilitySystem;

        public void OnDamageUpgrade()
        {
            damage.DamageUpgrade(damageIncrease);
            transform.gameObject.SetActive(false);
            abilitySystem.onAbilitySelect?.Invoke();
        }
    }
}