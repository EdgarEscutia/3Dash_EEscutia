using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;


public class PlayerController : MonoBehaviour
{
    [Header("Mesures")]

    public GameManager gameManager;

    public float moveSpeed = 5.0f;
    public float playerAcceleration = 0.0f;
    public float jumpSpeed;

    bool salta = false;
    bool isGrounded;

    public Vector3 moveVector;
    public Vector3 respawnPos;

    Rigidbody rb;

   
    void Start()
    {
         rb = GetComponent<Rigidbody>();
        respawnPos = transform.position;
       
    }

    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                salta = true;
                isGrounded = false;
            }
        }

    }
    private void FixedUpdate()
    {
        if (salta == true)
        {
            GetComponent<Rigidbody>().velocity += jumpSpeed * Vector3.up;
            salta = false;
        }


        Vector3 moveVector = new Vector3(1, 0, 0);
        rb.MovePosition(transform.position + moveVector * Time.deltaTime * (moveSpeed + playerAcceleration));
        if (playerAcceleration < 5)
        {
            playerAcceleration = playerAcceleration + 0.01f;
        }

    }
    public void AccelerationNull()
    { 
        playerAcceleration = 0.0f; 
    }
    public void Respawn()
    {
        
        rb.velocity = new Vector3(0, 0, 0);
        rb.angularVelocity = Vector3.zero;
        transform.position = respawnPos;

    }
   
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            gameManager.SetStart();
        }
        if(other.gameObject.layer == 8)
        {
            isGrounded= true;   
        }
        if(other.gameObject.layer ==9)
        {
            Debug.Log("Particle Red");
        }
        if (other.gameObject.layer == 10)
        {
            Debug.Log("Particle Blue");
        }
    }

    public void OnDestroy()
    {
        Destroy(GetComponent<Rigidbody>());
    }   
}
