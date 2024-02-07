using General.Abstracts;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour, IDamagable
{
    [SerializeField, Range(10, 100)] private int maxHealth;

    [HideInInspector] public UnityEvent onDie = new UnityEvent();
    [HideInInspector] public UnityEvent<int> onApplyDamage = new UnityEvent<int>();


    public int CurrentHealth
    {
        get;
        private set;
    }
    
    public void Initialize()
    {
        CurrentHealth = maxHealth;
        onApplyDamage?.Invoke(CurrentHealth);
    }

    public void ApplyDamage(int damage)
    {
        if (CurrentHealth - damage <= 0) onDie?.Invoke();
        CurrentHealth -= damage;
        onApplyDamage?.Invoke(CurrentHealth);
    }
}
