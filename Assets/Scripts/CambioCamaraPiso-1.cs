using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CambioCamaraPiso : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private CinemachineVirtualCamera camaraAnterior;
    [SerializeField] private CinemachineVirtualCamera camaraLateral;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private CinemachineBrain cerebro;
    
    private void Start()
    {
        
        cerebro = Camera.main.GetComponent<CinemachineBrain>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) { 
        PlayerDynamics player = other.GetComponent<PlayerDynamics>();
            if (player != null)
            {
                cerebro.m_DefaultBlend.m_Time = 0.3f;
                camaraAnterior.Priority = 0;
                camaraLateral.Priority = 15;
                spriteRenderer.enabled = true;
                PlayerDynamics.startingPosition = other.transform.position;
            }
        }

        
    }
}
