using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Video;
using Cinemachine;

public class PlayerDynamics : MonoBehaviour
{
    private Rigidbody rb;
    private float hInput;
    private float vInput;
    public static Vector3 startingPosition;
    [SerializeField] private CinemachineVirtualCamera topDownCamara;
    [SerializeField] private CinemachineVirtualCamera normalCamera;  
    [SerializeField] private float fuerzaMovimiento;
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private float fuerzaSaltoRaycast;
    [SerializeField] private float fuerzaSaltoAbajo;
    private float distanciaDireccionInteractuable = 1f;
    public static PlayerDynamics restablecerPosicion;
    private CanvasManager canvasManager;    
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startingPosition = transform.position;
        canvasManager = FindObjectOfType<CanvasManager>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        if (transform.position.y <= -2)
        {
            RestablecerPosicion(startingPosition);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Physics.Raycast(transform.position, Vector3.down, fuerzaSaltoRaycast))
            {
                rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);  
            }
        
            if(!Physics.Raycast(transform.position, Vector3.down, fuerzaSaltoRaycast))
            {
                rb.AddForce(Vector3.down * fuerzaSaltoAbajo, ForceMode.Impulse);
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(Physics.Raycast(transform.position, Vector3.forward, out RaycastHit hit, distanciaDireccionInteractuable))
            {
                if (hit.transform.TryGetComponent(out BotonPulsable boton))
                {
                    boton.Interactuar();
                }
            }
        }
    }
  
    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(hInput, 0, vInput).normalized * fuerzaMovimiento, ForceMode.Force);
        
    }

    public void RestablecerPosicion(Vector3 posicionReinicio)
    {
        canvasManager.ReduccionBarra();
        transform.position = Vector3.MoveTowards(transform.position, posicionReinicio, 2000f);
        rb.velocity = Vector3.zero;
        normalCamera.Priority = 10;
        topDownCamara.Priority = 0;
    }

    

}
