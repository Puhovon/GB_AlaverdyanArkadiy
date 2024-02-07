using General.Abstracts;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour, IDamagable
{
    [SerializeField, Range(10, 100)] private int maxHealth;

    public UnityEvent onDie = new UnityEvent();
    public UnityEvent onApplyDamage = new UnityEvent();


    public int CurrentHeal
    {
        get;
        private set;
    }
    
    private void Start()
    {
        CurrentHeal = maxHealth;
    }

    public void ApplyDamage(int damage)
    {
        if (CurrentHeal - damage <= 0) onDie?.Invoke();
        CurrentHeal -= damage;
        onApplyDamage?.Invoke();
        print(CurrentHeal);
    }
}
