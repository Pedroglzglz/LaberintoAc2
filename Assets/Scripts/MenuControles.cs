using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControles : MonoBehaviour
{
    [SerializeField] private GameObject panelMenu;
    [SerializeField] private Button botonOK;
    private Crono crono;
    // Start is called before the first frame update
    void Start()
    {
        panelMenu.SetActive(true);
        botonOK.onClick.AddListener(StartGame);
        crono = FindObjectOfType<Crono>();
        crono.CronoPara();
    }

    // Update is called once per frame
    void StartGame()
    {
        panelMenu.SetActive(false);
        crono.CronoEmpieza();
    }
}
