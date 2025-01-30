using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;

public class CambioCamaraFinal : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera topDownCamara;
    [SerializeField] private CinemachineVirtualCamera defaultCamara;
    [SerializeField] private TMP_Text textoFinal;
    private Crono cronometro;
    private Vector3 nuevaPosicion;
    private ComportamientoPuntos punteador;
    private AudioSource audio;
    private TextoFinal texto;
    private void Start()
    {
        cronometro = FindObjectOfType<Crono>();
        audio = GetComponent<AudioSource>();
        punteador = GetComponent<ComportamientoPuntos>();
        texto = FindObjectOfType<TextoFinal>();
        
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            topDownCamara.Priority = 0;
            defaultCamara.Priority = 10;
            nuevaPosicion = transform.position + new Vector3(0, 0, 10);
            PlayerDynamics.startingPosition = nuevaPosicion;
            cronometro.CronoPara();
            audio.Play();
            ComportamientoPuntos.ComportamientoCrono();
            textoFinal = texto.ResultadoFinal(textoFinal);
            
        }
    }
}
