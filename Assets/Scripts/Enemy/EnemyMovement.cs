using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private float speed;

        private NavMeshAgent _agent;
        private Transform playerTransform;

        
        public void Initialize(Transform playerTransform)
        {
            this.playerTransform = playerTransform;
            _agent = GetComponent<NavMeshAgent>();
            _agent.speed = speed;
        }

        private void Update()
        {
            transform.LookAt(playerTransform);
            _agent.destination = playerTransform.position;
            
            _agent.isStopped = false;
            if(_agent.remainingDistance <= 1.5f)
            {
                _agent.isStopped = true;
            }
        }
    }
}