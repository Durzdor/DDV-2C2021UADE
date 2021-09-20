using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarterAssets
{

    public class Respawn : MonoBehaviour
    {
        [SerializeField] private Transform player;
        [SerializeField] private Transform respawnPoint;
        private bool isTeleporting;
        [SerializeField] private ThirdPersonController thirdPersonController;

        private void OnTriggerEnter(Collider other)
        {

            if (other.CompareTag("Player"))
            {
                print("Player");               
                Teleport(respawnPoint);

            }

        }

        public void Teleport(Transform pos)
        {
            if (isTeleporting) return;
            StartCoroutine(TeleportTo(pos));
        }

        private IEnumerator TeleportTo(Transform pos)
        {
            isTeleporting = true;
            thirdPersonController.enabled = false;
           player. transform.position = pos.position;
            player.transform.rotation = pos.rotation;
            yield return new WaitForSeconds(0.15f);
            thirdPersonController.enabled = true;
            isTeleporting = false;
           
        }
    }
}
