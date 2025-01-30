using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CambioCamaraBajada : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera topDownCamara;
    [SerializeField] private CinemachineVirtualCamera closePlayerCamara;
    private CinemachineBrain cerebro;
    // Start is called before the first frame update

    private void Start()
    {
        cerebro = Camera.main.GetComponent<CinemachineBrain>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            cerebro.m_DefaultBlend.m_Time = 0f;
            topDownCamara.Priority = 0;
            closePlayerCamara.Priority = 10; 
        }
    }
}
