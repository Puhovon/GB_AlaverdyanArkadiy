using System;
using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private Transform playerTransform;
        [SerializeField] private float speed;
        private NavMeshAgent _agent;

        private void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
            _agent.speed = speed;
        }

        private void Update()
        {
            transform.LookAt(playerTransform);
            _agent.destination = playerTransform.position;
            
            _agent.isStopped = false;
            if(_agent.remainingDistance <= 1.5f) _agent.isStopped = true;
        }
    }
}