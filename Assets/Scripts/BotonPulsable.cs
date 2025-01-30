using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BotonPulsable : MonoBehaviour
{
    [SerializeField]private GameManagerSO gameManager;
    [SerializeField] private int idBoton;
    private Rigidbody rb;
    private Rigidbody parentRb;
    private bool botonPulsado = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        parentRb = transform.parent.GetComponentInParent<Rigidbody>();
       
    }

    public void Interactuar()
    {
        if (botonPulsado)
        {
            gameManager.BotonPulsado(idBoton);
            parentRb.position = parentRb.position - new Vector3(0f, 0f, -0.20f);
            botonPulsado = false;
        }             
    }
}
