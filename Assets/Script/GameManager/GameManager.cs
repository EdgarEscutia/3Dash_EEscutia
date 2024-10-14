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

    [SerializeField] Camera mainCamara;

    void Start()
    {
        //scoreDead = GetComponent<TMP_Text>();
        
    }
    public void SetStart()
    {
        playerController.Respawn();
        playerController.AccelerationNull();
        scoreDead.text = $" ATTEMPT  {deathCount}";
        deathCount++;
    }

    public bool SumarParticulasRojas()
    {
        if(particle.particle_Red == 5)
        {
            Debug.Log("Particulas rojas llenas");
            return true;
            
        }
        else
        {
            particle.particle_Red++;
            return false;
        }
       
        
    }

    public void activarRojo()
    {
           
    }
    public void activarAzul()
    {

    }

    public bool SumarParticulasAzules()
    {
        if (particle.particle_Blue == 5)
        {
            Debug.Log("Particulas azules llenas");
            return true;
        }
        else
        {
            particle.particle_Blue++;
            return false;
        }
    }
    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            SetStart();
        }
    }
}
