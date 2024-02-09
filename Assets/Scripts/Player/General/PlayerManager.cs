using General.Entities;
using UnityEngine;

namespace Player.General
{
    public class PlayerManager : MonoBehaviour
    {
        [SerializeField] private Health health;
        [SerializeField] private PlayerInputs inputs;
        [SerializeField] private PlayerMovement movement;
        [SerializeField] private PlayerAttack attack;

        public void Initialize()
        {
            health.Initialize();
            movement.Initialize(inputs);
            attack.Initialize(inputs);
        }
    }
}