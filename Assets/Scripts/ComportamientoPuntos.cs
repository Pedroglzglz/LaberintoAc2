using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoPuntos : MonoBehaviour
{
    private Crono crono;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public static void ComportamientoCrono()
    {
        
        float tiempoCrono = Crono.empezarTiempo;
        if (tiempoCrono < 10)
        {
            Debug.Log("Increíble");
        }
        else
        {
            Debug.Log("Puedes hacerlo mejor.");
        }
    }
}
