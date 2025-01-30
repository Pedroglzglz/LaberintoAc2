using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Crono : MonoBehaviour
{
    public static float empezarTiempo;
    public bool tiempoActivo;
    [SerializeField] private TMP_Text texto;
    // Start is called before the first frame update
    void Start()
    {
        empezarTiempo = 0;
        tiempoActivo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoActivo)
        {
            empezarTiempo += Time.deltaTime;
            int minutos = Mathf.FloorToInt(empezarTiempo / 60F);
            int segundos = Mathf.FloorToInt(empezarTiempo % 60F);
            int milisegundos = Mathf.FloorToInt((empezarTiempo * 100F) % 100F);
            texto.text = string.Format("{0:00}:{1:00}:{2:00}", minutos, segundos, milisegundos);
            //Debug.Log(empezarTiempo);
        }
    }

    public void CronoEmpieza()
    {
        tiempoActivo = true;
    }

    public void CronoPara()
    {
        tiempoActivo = false;
    }
}
