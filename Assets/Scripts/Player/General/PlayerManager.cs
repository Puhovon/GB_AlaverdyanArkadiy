using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Player
{
    public class PlayerManager : MonoBehaviour
    {
        [SerializeField] private Health health;

        private void Start()
        {
            health.Initialize();
        }
    }
}