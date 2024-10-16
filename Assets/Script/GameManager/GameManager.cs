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

    public PlayerController playerController;
    public float playerAcceleration;

    public TMP_Text scoreDead;
    public int deathCount = 1;


    public Particle particle;

    [Header("CAMARAS")]
    [SerializeField] CinemachineVirtualCamera camara_Red;
    [SerializeField] CinemachineVirtualCamera camara_Blue;

    [SerializeField] CinemachineVirtualCamera camara_Principal;

    void Start()
    {
        
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            SetStart();
        }
        ActivarBottonRojo();
        ActivarBottonAzul();
        Debug.Log(particle.particle_Red);
    }
    public void SetStart()
    {
        playerController.Respawn();
        playerController.AccelerationNull();
        RestartParticle();
        RestartCameras();
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
        if (Input.GetKeyDown(KeyCode.T) && particle.particle_Red == 5)
        {
            Debug.Log("Activar P. Red");
            activarRojo();
        }
    }
    public void ActivarBottonAzul() //BOTON AZUL
     {
        if (Input.GetKeyDown(KeyCode.T) && particle.particle_Blue == 5)
        {
            Debug.Log("Activar P. Red");
            activarAzul();
        }
    }
    public void SumarParticulasRojas()
    {
        if(particle.particle_Red == 5)
        {
            Debug.Log("Particle red == 5");
           
        }
        else if(particle.particle_Red < 5)
        {
            particle.particle_Red++;
        }
    }

    public void SumarParticulasAzules()
    {
        if (particle.particle_Blue == 5)
        {
           
            Debug.Log("Activar P. Blue");
                
            
        }
        else if (particle.particle_Blue < 5)
        {
            particle.particle_Blue++;
        }
    }
    public void activarRojo()
    {
        camara_Red.Priority = 40;
        camara_Red.enabled = true;
        camara_Principal.enabled = false;

        playerController.moveSpeed = playerController.inicialMoveSpeed * 1.5f;
        particle.particle_Red = 0;
    }
    public void activarAzul() 
    {
        camara_Blue.Priority = 40;
        camara_Blue.enabled = true;
        camara_Principal.enabled = false;

        playerController.moveSpeed = playerController.inicialMoveSpeed / 1.5f;
        particle.particle_Red = 0;
        RestartParticle();
    }

    
}
