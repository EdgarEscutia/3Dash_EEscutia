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


    public void particleRed()
    {

            playerController.moveSpeed = playerController.inicialMoveSpeed * 1.5f;     
    }
    public void particleBlue()
    {

        playerController.moveSpeed = playerController.inicialMoveSpeed / 1.5f;
                
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
