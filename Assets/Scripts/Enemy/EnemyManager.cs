using General.Entities;
using UnityEngine;

namespace Enemy
{
    public class EnemyManager : MonoBehaviour
    {
        [SerializeField] private EnemyDie die;
        [SerializeField] private EnemyMovement movement;
        [SerializeField] private EnemyAttack attack;
        [SerializeField] private Health health;
        [SerializeField] private Transform playerTransform;
        [SerializeField] private EnemyHealthBar hpBar;
        private void Start()
        {
            movement.Initialize(playerTransform);
            health.Initialize();
            hpBar.Initialize();
        }
    }
}