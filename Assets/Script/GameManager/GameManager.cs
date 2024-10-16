using Cinemachine;
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


    [SerializeField] CinemachineVirtualCamera camara_Red;
    [SerializeField] CinemachineVirtualCamera camara_Blue;

    [SerializeField] CinemachineVirtualCamera camara_Principal;

    void Start()
    {
        //scoreDead = GetComponent<TMP_Text>();
        
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            SetStart();
        }
    }
    public void SetStart()
    {
        playerController.Respawn();
        playerController.AccelerationNull();
        RestartParticle();
        scoreDead.text = $" ATTEMPT  {deathCount}";
        deathCount++;
    }

    public void RestartParticle()
    {
        particle.particle_Red = 0;
        particle.particle_Blue = 0;
    }

    public void SumarParticulasRojas()
    {
        if(particle.particle_Red == 5)
        {
            activarRojo();
        }
        else
        {
            particle.particle_Red++;
        }
    }

    public void SumarParticulasAzules()
    {
        if (particle.particle_Blue == 5)
        {
            activarAzul();
        }
        else
        {
            particle.particle_Blue++;
        }
    }
    public void activarRojo()
    {
        camara_Red.Priority = 40;
        camara_Red.enabled = true;
        //camara_Principal.enabled = false;
        
        playerController.moveSpeed = playerController.inicialMoveSpeed * 1.5f;
        particle.particle_Red = 0;
    }
    public void activarAzul()
    {
        playerController.moveSpeed = playerController.inicialMoveSpeed / 1.5f;
        particle.particle_Red = 0;
    }

    
}
