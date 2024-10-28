using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;


public class PlayerController : MonoBehaviour
{
    // "Singleton"
    public static PlayerController instance;

    [Header("FICHEROS")]
    public GameManager gameManager;
    public Particle particle;
    public PortalManager portalManager;

    [Header("VELOCIDAD")]
    public float inicialMoveSpeed = 6;
    public float moveSpeed = 6;

    [Header("ACELERACION")]
    public float playerAcceleration = 0.0f;
    
    [Header("SALTO")]
    public float jumpSpeed;

    bool salta = false;
    bool isGrounded;

    Vector3 moveVector;
    Vector3 respawnPos;

    Rigidbody rb;

   
    void Start()
    {
        //INICIAR EL RIGIDBODY 
         rb = GetComponent<Rigidbody>();

        //GUARDAR POSICION INICIAL
        respawnPos = transform.position;
        
       
    }

    void Update()
    {
        if (isGrounded) // Saltar y isGrounded
        {
            if (Input.GetKeyDown(KeyCode.Space)) //TECLA DE SALTO
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

        if (playerAcceleration < 5) //ACCELERACION LIMITE DE PERSONAJE
        {
            playerAcceleration = playerAcceleration + 0.01f;
        }

    }
    public void AccelerationNull() //FUNCION ACCELERACION
    {
        playerAcceleration = 0.0f;
        moveSpeed = 10.0f * Time.deltaTime;
    }
    public void Respawn() //REVIVIR AL INICIO DEL NIVEL
    {
        
        rb.velocity = new Vector3(0, 0, 0) *Time.deltaTime;
        rb.angularVelocity = Vector3.zero;
        transform.position = respawnPos;


    }
   
    public void OnTriggerEnter(Collider other) //COLLIDERS
    {
        if (other.gameObject.layer == 7) //OBSTACULOS
        {
            gameManager.SetStart();
        }
        if(other.gameObject.layer == 8) // GROUNDED
        {
            isGrounded= true;   
        }
        if(other.gameObject.layer ==9) //PARTICULA ROJA
        {
            gameManager.SumarParticulasRojas();
        }
        if (other.gameObject.layer == 10) //PARTICULA AZUL
        {
            gameManager.SumarParticulasAzules();
        }
        if(other.gameObject.layer == 11) //PORTAL ENTRADA
        {
            portalManager.SetStart();
        }
        if (other.gameObject.layer == 12) //PORTAL ENTRADA
        {
            Debug.Log("Salida del portal");
        }
        if (other.gameObject.layer == 13) //PORTAL ENTRADA
        {
            portalManager.AñadirBarraPortal();
        }
        if (other.gameObject.layer == 14) //PORTAL ENTRADA
        {            
            portalManager.QuitarBarraPortal();
        }
        if (other.gameObject.layer == 15) //CARGA SIGUIENTE PREFAB 
        {
            gameManager.GenerateLevels();           
        }
    }

    public void OnDestroy() //DESTRUIR EL RIGIDBODY
    {
        Destroy(GetComponent<Rigidbody>());
    }   
}
