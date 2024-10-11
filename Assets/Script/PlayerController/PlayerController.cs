using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;


public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;

    [Header("Mesures")]
    public float moveSpeed = 5.0f;
    public Vector3 moveVector;
    public float playerAcceleration = 0.0f;
    public float jumpSpeed;
    bool salta = false;

    public Vector3 respawnPos;

    Rigidbody rb;
    bool isGrounded;

   
    void Start()
    {
         rb = GetComponent<Rigidbody>();
        respawnPos = transform.position;
       
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
    }

    public void OnDestroy()
    {
        Destroy(GetComponent<Rigidbody>());
    }
    void Update()
    {
        if(isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {            
                salta = true;
                isGrounded = false;
            }
        }
        
            //int layerMask = 1 << 7;

            //// Does the ray intersect any objects which are in layer 8?
            ////layerMask = ~layerMask;
            //RaycastHit hit;

            //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
            //{
            //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.white);
            //    Debug.Log("Did Hit");
            //}
            //else
            //{
            //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            //    Debug.Log("Did not Hit");
            //}
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
        if(playerAcceleration < 5)
        {
            playerAcceleration = playerAcceleration + 0.01f;
        }
        
    }
    
    
}
