using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UIElements;
public class CambioCamar : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera topDownCamara;
    [SerializeField] private CinemachineVirtualCamera defaultCamara;
    private GameObject paredIzq;
    private GameObject paredDcha;
    private Vector3 nuevaPosicion;
    private PlayerDynamics player;
   

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            topDownCamara.Priority = 10;
            defaultCamara.Priority = 0;
            nuevaPosicion = transform.position;
            PlayerDynamics.startingPosition = nuevaPosicion;  

        }
    }
}
