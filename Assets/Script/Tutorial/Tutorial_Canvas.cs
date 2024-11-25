using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class Tutorial_Canvas : MonoBehaviour
{
    public static Tutorial_Canvas instance;

    [Header("Panel")]
    [SerializeField] GameObject PanelGeneral;

    [Header("Textos")]
    [SerializeField] GameObject textParticles;
    [SerializeField] GameObject textPortal;
    [SerializeField] GameObject textEnergia;
    [SerializeField] GameObject textMenu;


    public int count = 0;
    public int separar = 0;

    void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;
        PanelGeneral.SetActive(true);

        if (count == 0)
        { textParticles.SetActive(true); }
 
        else if(count == 1)
        { textPortal.SetActive(true);}

        else if (count == 2)
        { textEnergia.SetActive(true); }

        else if (count == 3)
        { textMenu.SetActive(true); }
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T) && count == 0)
        {
            PanelGeneral.SetActive(false);
            textParticles.SetActive(false);

            Time.timeScale = 1f;

            count++;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && count == 1)
        {
            PanelGeneral.SetActive(false);
            textPortal.SetActive(false); 
            
            Time.timeScale = 1f;
            separar = 1;
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && count == 2 && separar == 1)
        {
            PanelGeneral.SetActive(false);
            textEnergia.SetActive(false);

            Time.timeScale = 1f;
            separar = 2;
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && count == 3 && separar == 2)
        {
            PanelGeneral.SetActive(false);
            textMenu.SetActive(false);

            Time.timeScale = 1f;
            separar = 0;
            count++;
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            count = 0;
            separar = 0;
        }
    }
}
