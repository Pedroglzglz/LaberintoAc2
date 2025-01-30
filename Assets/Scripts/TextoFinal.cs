using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoFinal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public TMP_Text ResultadoFinal(TMP_Text texto)
    {
        if (Crono.empezarTiempo >= 20)
        {
            texto.text = "Increíble";
        }
        else if (Crono.empezarTiempo >= 30)
        {
            texto.text = "No está mal";
        }
        else if(Crono.empezarTiempo >= 60)
        {
            texto.text = "Puedes hacerlo mejor";
        }
            return texto;
    }
}
