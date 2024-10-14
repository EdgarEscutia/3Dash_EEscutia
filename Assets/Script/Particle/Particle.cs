using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public PlayerController playerController;

    public int particle_Red;
    public int particle_Blue;

    [SerializeField] CinemachineVirtualCamera camara_Red;
    [SerializeField] CinemachineVirtualCamera camara_Blue;

    [SerializeField] Camera mainCamara;
    public void particleRed()
    {
        //if(particle_Red == 5)
        //{
            //camara_Red.enabled = true;
            //camara_Red.Priority = 30;

            playerController.moveSpeed = playerController.inicialMoveSpeed * 2;
        
       
            Debug.Log(playerController.moveSpeed);
    }
    public void particleBlue()
    {
        //if(particle_Blue == 5)
        //{
        //camara_Red.enabled = false;

        //camara_Blue.enabled = true;
        //camara_Blue.Priority = 30;
        playerController.moveSpeed = playerController.inicialMoveSpeed / 2;
        
        
        Debug.Log(playerController.moveSpeed);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
