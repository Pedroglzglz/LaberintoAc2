using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Impulsador : MonoBehaviour
{
    [SerializeField] private float fuerzaImpulso;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.TryGetComponent(out Rigidbody rb))
        {
            rb.AddForce(Vector3.up * fuerzaImpulso, ForceMode.Impulse);
            
        }
    }
}
