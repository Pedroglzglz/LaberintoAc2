using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoNoPermitido : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerDynamics player = other.GetComponent<PlayerDynamics>();
            if (player != null)
            {
                player.RestablecerPosicion(PlayerDynamics.startingPosition);
            }
        }
    }
}
