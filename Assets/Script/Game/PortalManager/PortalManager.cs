using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerController playerController;
    public BarraEnergia barraEnergia;
    public BarraPortal barraPortal;

    public bool salta;

    public void Start()
    {
        salta = true;
    }
    public void SetStart()
    {
        gameManager.RestartParticle();
        gameManager.RestartCameras();
        playerController.AccelerationNull();
        barraEnergia.Restart_Barra();
        barraPortal.ActivarBarraPortal();
    }

    public void AñadirBarraPortal()
    {
        if(salta)
        {
            barraPortal.AñadirVidaPortal();
            salta = false;
        }
    }
    public void QuitarBarraPortal()
    {
        if (salta)
        {
            barraPortal.QuitarVidaPortal();
            salta = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
