using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private Image imagen;
    [SerializeField] public Canvas canvasFinal;
    [SerializeField] public Button restartButton;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReduccionBarra()
    {
        imagen.fillAmount -= 0.25f;
        Debug.Log(imagen.fillAmount);
        if(imagen.fillAmount == 0)
        {
            FinalJuego();
        }
    }
   
    public void FinalJuego()
    {
        canvasFinal.enabled = true;
        Time.timeScale = 0f;
        restartButton.onClick.AddListener(RestartGame);
    }

    void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
