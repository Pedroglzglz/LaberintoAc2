using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MiGameManager")]
public class GameManagerSO : ScriptableObject
{
    public event Action<int> OnBotonPulsado;
    public void BotonPulsado(int idBoton)
    {
        //Lanzar un evento de que un botón ha sido pulsado
        OnBotonPulsado.Invoke(idBoton);
    }
}
