using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Input Actions")]
    [SerializeField] InputActionReference jump;

    [SerializeField] float playerjumpHeight;
    [SerializeField] float playerSpeed;

    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float gravityValue;
    


    Rigidbody rb;

    [SerializeField] CinemachineVirtualCamera cam;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
