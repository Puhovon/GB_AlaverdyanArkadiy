using Player;
using UnityEngine;

public class DamageAbility : MonoBehaviour
{
    [SerializeField] private int damageIncrease;
    [SerializeField] private PlayerAttack damage;

    public void OnDamageUpgrade()
    {
        damage.DamageUpgrade(damageIncrease);
    }
}
