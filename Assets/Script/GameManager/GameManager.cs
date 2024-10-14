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

    public void SumarParticulasRojas()
    {
        if(particle.particle_Red == 5)
        {
            Debug.Log("Particulas rojas llenas");
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
            Debug.Log("Particulas azules llenas");
        }
        else
        {
            particle.particle_Blue++;
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
