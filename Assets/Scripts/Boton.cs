using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    [SerializeField] private GameManagerSO gM;
    [SerializeField] private int idBoton;
    private Rigidbody rb;
    private Rigidbody parentRb;
    private bool botonPulsado = true;
    private float umbralFuerza = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        parentRb = transform.parent.GetComponentInParent<Rigidbody>();
           
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.TryGetComponent(out PlayerDynamics player))
        {
            foreach(ContactPoint contact in collision.contacts)
            {
                Vector3 velocidadRelativa = collision.relativeVelocity;
                float fuerzaImpacto = rb.mass * velocidadRelativa.magnitude;

                if(fuerzaImpacto >= umbralFuerza)
                {
                    if (botonPulsado)
                    {
                        botonPulsado = false;
                        gM.BotonPulsado(idBoton);
                        parentRb.position = parentRb.position - new Vector3(0f, 0.49f, 0f);
                        
                    }
                    else
                    {
                        break;
                    }   
                }
            }

        }

    }
}
