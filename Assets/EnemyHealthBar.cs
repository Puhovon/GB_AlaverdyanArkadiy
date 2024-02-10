using General.Entities;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    [SerializeField] private Slider hpBar;
    [SerializeField] private Health health; 
    
    public void Initialize()
    {
        print("Initialize");
        health.onHealPointChanged.AddListener(OnHealthPointChanged);
    }

    private void OnHealthPointChanged(int hp)
    {
        print("HP CHanged");
        hpBar.value = hp;
    }
}
