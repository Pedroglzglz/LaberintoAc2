using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Pinchos : MonoBehaviour
{
    private PlayerDynamics player;
    
    

    private void Start()
    {
        
       
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerDynamics player = other.GetComponent<PlayerDynamics>();
            
            if (player != null) {
                player.RestablecerPosicion(PlayerDynamics.startingPosition);

            }
        }
    }
}
