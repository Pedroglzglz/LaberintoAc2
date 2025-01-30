using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Puerta : MonoBehaviour
{
    [SerializeField] private GameManagerSO gM;
    [SerializeField] private int idBoton;
    private AudioSource sonido;
    private bool abrir = false;
    // Start is called before the first frame update
    void Start()
    {
        gM.OnBotonPulsado += Abrir;
        sonido = GetComponent<AudioSource>();
        
    }


    private void Abrir(int idBotonPulsado)
    {
        if(idBotonPulsado == idBoton)
        {
            abrir = true;
            Sonar();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (abrir)
        {
            transform.Translate(Vector3.down * 2 * Time.deltaTime);  
            Destroy(gameObject, 2.5f);
        }
    }

    private void Sonar()
    {
        if (sonido == null)
        {
            Debug.LogError("Error: El AudioSource no está asignado en Puerta al intentar reproducir.");
            return;
        }

        sonido.Play();
    }
}
