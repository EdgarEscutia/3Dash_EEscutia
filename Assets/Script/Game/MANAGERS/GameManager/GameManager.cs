using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    // "Singleton"
    public static GameManager instance;

    [Header("LINKS")]
    public PlayerController playerController;
    public BarraEnergia barraEnergia;
    public Particle particle;
    public ObstacleManager obstacleManager;

    [Header("RESETS")]
    public TMP_Text scoreDead;
    public int deathCount = 1;


    [Header("CAMARAS")]
    [SerializeField] CinemachineVirtualCamera camara_Red;
    [SerializeField] CinemachineVirtualCamera camara_Blue;

    [SerializeField] CinemachineVirtualCamera camara_Principal;

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            SetStart();

        }
       
        ActivarBottonRojo();
        ActivarBottonAzul();
    }
    public void SetStart()
    {
        playerController.Respawn();
        playerController.AccelerationNull();
        RestartParticle();
        RestartCameras();
        barraEnergia.Restart_Barra();
        scoreDead.text = $" ATTEMPT  {deathCount}";
        deathCount++;
    }

    public void RestartParticle()
    {
        particle.particle_Red = 0;
        particle.particle_Blue = 0;
    }
    public void RestartCameras()
    {
        //Activar camara principal
        camara_Principal.enabled = true; 

        //Resetear Prioridades
        camara_Red.Priority = 0;
        camara_Blue.Priority = 0;

        //Desactivar camaras secundarias
        camara_Red.enabled = false;
        camara_Blue.enabled = false;
       
    }


    public void ActivarBottonRojo() //BOTON ROJO
    {
        if (Input.GetKeyDown(KeyCode.T) && particle.particle_Red == 5 && barraEnergia.EnergiaActual == 100)
        {
            barraEnergia.activarBarra();
            activarRojo();
            obstacleManager.ActivarObstacle();
            
        }
    }
    public void ActivarBottonAzul() //BOTON AZUL
     {
        if (Input.GetKeyDown(KeyCode.T) && particle.particle_Blue == 5 && barraEnergia.EnergiaActual == 100)
        {
            barraEnergia.activarBarra();
            activarAzul();
            obstacleManager.DesactivarObstacle();
        }
    }
    public void SumarParticulasRojas() //SUMAR ROJO
    {
        if(particle.particle_Red < 5)
        {
            particle.particle_Red++;
        }
        else
        {
            barraEnergia.ActivarBoton();
        }
    }

    public void SumarParticulasAzules() //SUMAR AZUL
    {
        if (particle.particle_Blue < 5)
        {
            particle.particle_Blue++;
        }
        else
        {
            barraEnergia.ActivarBoton();
        }
    }
    public void activarRojo() //ACTIVAR ROJO
    {
        camara_Red.Priority = 40;
        camara_Red.enabled = true;
        camara_Principal.enabled = false;

        playerController.moveSpeed = playerController.inicialMoveSpeed * 1.8f;
        particle.particle_Red = 0;
    }
    public void activarAzul() //ACTIVAR AZUL
    {
        camara_Blue.Priority = 40;
        camara_Blue.enabled = true;
        camara_Principal.enabled = false;

        playerController.moveSpeed = playerController.inicialMoveSpeed / 1.5f;
        particle.particle_Red = 0;

        RestartParticle();
    }  
}
