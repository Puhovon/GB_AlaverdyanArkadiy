using System;
using General.Abstracts;
using UnityEngine;
using UnityEngine.Events;

namespace Player
{
    public class PlayerAttack : MonoBehaviour, IAttaker
    {
        [SerializeField] private float distance;
        [SerializeField] private int damage;

        [SerializeField] private PlayerInputs _input;

        private void Start()
        {
            _input.onAttack.AddListener(CheckRaycastToAttack);
        }

        private void CheckRaycastToAttack()
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward, out hit, distance)) Attack(hit);
        }
        
        public void Attack(RaycastHit hit)
        {
            if (hit.transform.TryGetComponent(out IDamagable damagable))
            {
                damagable.ApplyDamage(damage);
            }
        }

        public void DamageUpgrade(int increaseDamage)
        {
            damage += increaseDamage;
        } 
    }
}