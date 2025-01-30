using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamaraTunel : MonoBehaviour
{

    [SerializeField] private CinemachineVirtualCamera tunnelCamara;
    [SerializeField] private CinemachineVirtualCamera playerCamara;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerCamara.Priority = 10;
            tunnelCamara.Priority = 0;  
        }
    }
}
