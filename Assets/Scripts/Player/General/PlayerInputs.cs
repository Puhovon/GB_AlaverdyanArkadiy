using UnityEngine;
using UnityEngine.Events;

namespace Player.General
{
    public class PlayerInputs : MonoBehaviour
    {
        public UnityEvent onAttack = new UnityEvent();

        public Vector3 MousePosition
        {
            get;
            private set;
        }

        public Vector2 Movement
        {
            get;
            private set;
        }
        
        private void Update()
        {
            GetMovementVector();
            GetMouseVector();
            IsAttackClicked();
        }

        private void GetMovementVector()
        {
            Movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }

        private void GetMouseVector()
        {
            MousePosition = Input.mousePosition;
        }

        private void IsAttackClicked()
        {
            if (Input.GetMouseButtonDown(0))
            {
                onAttack?.Invoke();
            }
        }
    }
}