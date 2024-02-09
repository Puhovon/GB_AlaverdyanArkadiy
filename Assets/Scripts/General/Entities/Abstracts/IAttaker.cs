using UnityEngine;

namespace General.Abstracts
{
    public interface IAttaker
    {
        public void Attack(RaycastHit hit);
    }
}