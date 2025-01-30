using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioVelocidad : MonoBehaviour
{
    [SerializeField] private float fuerzaMovimiento;
    
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.TryGetComponent(out Rigidbody rb))
        {
            rb.AddForce(new Vector3(0f, 0.25f, -0.5f) * fuerzaMovimiento, ForceMode.Impulse);
        }
    }
}
