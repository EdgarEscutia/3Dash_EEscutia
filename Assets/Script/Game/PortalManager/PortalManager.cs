using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerController playerController;
    public BarraEnergia barraEnergia;
    public BarraPortal barraPortal;
    public void SetStart()
    {
        gameManager.RestartParticle();
        gameManager.RestartCameras();
        playerController.AccelerationNull();
        barraEnergia.Restart_Barra();
        barraPortal.ActivarBarraPortal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
