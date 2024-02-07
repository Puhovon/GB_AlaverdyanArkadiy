using System;
using General.Abstracts;
using UnityEngine;

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

        private void Update()
        {
            
        }

        public void CheckRaycastToAttack()
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

        private void OnDrawGizmos()
        {
            Gizmos.DrawRay(new Ray(transform.position, transform.forward));
            Gizmos.color = Color.red;
        }
    }
}