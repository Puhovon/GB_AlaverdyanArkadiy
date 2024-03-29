﻿using General.Abstracts;
using UnityEngine;

namespace Player.General
{
    public class PlayerAttack : MonoBehaviour, IAttaker
    {
        [SerializeField] private float distance;
        [SerializeField] private int damage;

        private PlayerInputs _input;

        public void Initialize(PlayerInputs input)
        {
            _input = input;
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