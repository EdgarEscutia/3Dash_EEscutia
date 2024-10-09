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
    public Vector3 moveVector;
    public float playerAcceleration = 0.5f;
    public float jumpSpeed;
    bool salta = false;

    Rigidbody rb;

    void Start()
    {
         rb = GetComponent<Rigidbody>();

    }
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            salta = true;
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
        playerAcceleration = playerAcceleration + 0.01f;
    }
    
    
}
