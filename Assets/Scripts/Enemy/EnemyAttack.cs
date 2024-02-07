using System;
using System.Collections;
using General.Abstracts;
using UnityEngine;

namespace Enemy
{
    public class EnemyAttack : MonoBehaviour, IAttaker
    {
        [SerializeField] private int damage;
        [SerializeField] private int range;
        [SerializeField] private int secondsToNextAttack;

        private bool canAttack = true;

        private RaycastHit hit;

        private void IsPlayerInAttackDistance()
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, range)) IsEnemyCanAttack();
        }

        private void IsEnemyCanAttack()
        {
            if (canAttack)
            {
                Attack(hit);
            }
        }
        
        public void Attack(RaycastHit hit)
        {
            if(hit.transform.TryGetComponent(out IDamagable damageble)) damageble.ApplyDamage(damage);
            canAttack = false;
            StartCoroutine(Reload());
        }

        private IEnumerator Reload()
        {
            yield return new WaitForSeconds(secondsToNextAttack);

            canAttack = true;
        }

        private void OnTriggerStay(Collider other)
        {
            IsPlayerInAttackDistance();
        }
        
    }
}