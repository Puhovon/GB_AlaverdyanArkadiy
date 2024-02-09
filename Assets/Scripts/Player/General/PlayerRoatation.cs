using UnityEngine;

namespace Player.General
{
    public class PlayerRoatation : MonoBehaviour
    {
        float camRayLength = 100f;

        void FixedUpdate()
        {
            Turning();
        }


        void Turning()
        {
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(camRay, out hit, camRayLength))
            {
                Vector3 playerToMouse = hit.point - transform.position;

                playerToMouse.y = 0f;

                Quaternion newRotation = Quaternion.LookRotation(playerToMouse);

                transform.rotation = newRotation;
            }
        }
    }
}