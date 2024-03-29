using UnityEngine;

namespace Player.General
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody rigidbody;

        [SerializeField, Range(1, 10, order = 1)]
        private int speed;

        [SerializeField] private PlayerInputs input;

        private Vector2 moveDirrection;

        public void Initialize(PlayerInputs input)
        {
            this.input = input;
        }

        private void FixedUpdate()
        {
            moveDirrection = input.Movement;
            SetVelocity();
        }

        private void SetVelocity()
        {
            rigidbody.velocity = new Vector3(moveDirrection.x * speed, 0, moveDirrection.y * speed);
        }

        public void OnSpeedUpgrade(int speedIncrease)
        {
            speed += speedIncrease;
        }
    }
}