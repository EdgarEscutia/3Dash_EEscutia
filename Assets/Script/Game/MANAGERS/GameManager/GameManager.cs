 using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using Random = UnityEngine.Random;




public class GameManager : MonoBehaviour
{
    // "Singleton"
    public static GameManager instance;

    [Header("LINKS")]
    public PlayerController playerController;
    public ChunkManager chunkManager;
    public BarraEnergia barraEnergia;
    public Particle particle;
    public ObstacleManager obstacleManager;
    public PortalManager portalManager;
    public BarraPortal barraPortal;

    public AutoGererateChunks autoGererateChunks;

    [Header("RESETS")]
    public TMP_Text scoreDead;
    public int deathCount = 1;


    [Header("CAMARAS")]
    [SerializeField] CinemachineVirtualCamera camara_Red;
    [SerializeField] CinemachineVirtualCamera camara_Blue;

    [SerializeField] CinemachineVirtualCamera camara_Principal;

    [Header("CANVAS")]
    [SerializeField] Canvas MenuInGame;

    public void ActivarSiguienteChunk()
    {
        chunkManager.ColocarSiguienteChunk();
    }

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
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            MenuInGame.GetComponent<Canvas>().enabled = true;
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
        barraPortal.DesactivarBarra();
        obstacleManager.RestartObstacles();
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

        playerController.moveSpeed = playerController.inicialMoveSpeed * 1.8f *Time.deltaTime;
        particle.particle_Red = 0;
    }
    public void activarAzul() //ACTIVAR AZUL
    {
        camara_Blue.Priority = 40;
        camara_Blue.enabled = true;
        camara_Principal.enabled = false;

        playerController.moveSpeed = playerController.inicialMoveSpeed / 1.5f * Time.deltaTime;
        particle.particle_Red = 0;

        RestartParticle();
    }

    public void RandomReset()
    {
        float guardado = playerController.moveSpeed;
        playerController.moveSpeed = 0;

        float randomNumber = (Random.Range(0, 2));
        bool soloUnaVez = true;
        
        
        if(randomNumber <= 0.5f && soloUnaVez == true) //MUERTO
        {
            soloUnaVez = false;
            SetStart();
        }

        if(randomNumber > 0.5f && soloUnaVez == true) //REVIVE
        {
            barraPortal.AņadirVidaPortal();
            soloUnaVez = false;
            playerController.moveSpeed = guardado;
        }
    }
    public int contador = 0;
    public void GenerateLevels()
   {
       

       //if(contador == 1)
       //{
       //    autoGererateChunks.AutoGenerateMeta();

           
       //}
       if(contador == 0)
       {
           autoGererateChunks.AutoGenerate();
            contador = 1;
       }
       //else
       //{
       //    autoGererateChunks.NextChunk();
       //}
   }
}
