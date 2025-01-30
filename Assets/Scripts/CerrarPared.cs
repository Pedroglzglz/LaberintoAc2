using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarPared : MonoBehaviour
{
    
    [SerializeField] private float fuerzaCierre;
    [SerializeField] private GameObject paredIzq;
    [SerializeField] private GameObject paredDcha;
    private Rigidbody rbIzq;
    private Rigidbody rbDcha;
    private bool cerrarParedes = false;
    // Start is called before the first frame update
    void Start()
    {
       rbIzq = paredIzq.GetComponent<Rigidbody>();
       rbDcha = paredDcha.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cerrarParedes)
        {
            rbIzq.transform.Translate(Vector3.right * fuerzaCierre * Time.deltaTime, Space.World);
            rbDcha.transform.Translate(Vector3.left * fuerzaCierre * Time.deltaTime, Space.World);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Tocado");
            cerrarParedes = true;
            
        }
    }

    
}
