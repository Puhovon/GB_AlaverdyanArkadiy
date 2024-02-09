using General.Abstracts;
using UnityEngine;
using UnityEngine.Events;

namespace General.Entities
{
    public class Health : MonoBehaviour, IDamagable
    {
        [SerializeField, Range(10, 100)] private int maxHealth;

        [HideInInspector] public UnityEvent onDie = new UnityEvent();
        [HideInInspector] public UnityEvent<int> onHealPointChanged = new UnityEvent<int>();


        public int CurrentHealth { get; private set; }

        public void Initialize()
        {
            CurrentHealth = maxHealth;
            onHealPointChanged?.Invoke(CurrentHealth);
        }

        public void ApplyDamage(int damage)
        {
            if (CurrentHealth - damage <= 0) onDie?.Invoke();
            CurrentHealth -= damage;
            onHealPointChanged?.Invoke(CurrentHealth);
        }

        public void UpgradeHealth(int healthIncrease)
        {
            maxHealth += healthIncrease;
            CurrentHealth += healthIncrease;
            onHealPointChanged?.Invoke(CurrentHealth);
        }

        public void FullHeal()
        {
            CurrentHealth = maxHealth;
            onHealPointChanged?.Invoke(CurrentHealth);
        }
    }
}