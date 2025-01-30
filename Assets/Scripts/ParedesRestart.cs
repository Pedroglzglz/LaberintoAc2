using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ParedesRestart : MonoBehaviour
{

    [SerializeField]private GameObject pared;
    
    private bool sobrepasado = false;

    // Start is called before the first frame update
 

    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!sobrepasado)
            {
                PlayerDynamics player = other.GetComponent<PlayerDynamics>();
                player.RestablecerPosicion(PlayerDynamics.startingPosition);
                sobrepasado = true;
                
            }
        }
    }
}
