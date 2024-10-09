using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    [Header("Input Actions")]
    [SerializeField] InputActionReference jump;

    public float moveSpeed = 5.0f;
    //public Vector3 moveVector;
    public float playerAcceleration = 0.5f;

    Rigidbody rb;

    void Start()
    {
         rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        //rb.MovePosition(transform.position + moveVector * Time.deltaTime * (moveSpeed + playerAcceleration));
        playerAcceleration = playerAcceleration + 0.01f;
    }
    private void FixedUpdate()
    {
       Vector3 moveVector = new Vector3(1, 0, 0);
        rb.MovePosition(transform.position + moveVector *Time.deltaTime * (moveSpeed + playerAcceleration));
        
    }

}
