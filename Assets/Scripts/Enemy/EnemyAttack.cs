using General.Abstracts;
using UnityEngine;

namespace Enemy
{
    public class EnemyAttack : MonoBehaviour, IAttaker
    {
        [SerializeField] private int damage;
        [SerializeField] private int range;
        
        private void IsPlayerInAttackDistance()
        {
            
        }
        
        public void Attack(RaycastHit hit)
        {
            
        }
    }
}