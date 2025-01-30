using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadRampa : MonoBehaviour
{
    [SerializeField] private float fuerzaImpulso;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.TryGetComponent(out Rigidbody rb))
        {
            rb.AddForce(new Vector3(0f, 0.5f, 0.5f) * fuerzaImpulso, ForceMode.Impulse);
        }
    }
}
