using System;
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
        private void Start()
        {
            movement.Initialize(playerTransform);
            health.Initialize();
        }
    }
}