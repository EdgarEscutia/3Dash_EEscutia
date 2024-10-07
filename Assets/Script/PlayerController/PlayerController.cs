using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    //[Header("Input Actions")]
    //[SerializeField] InputActionReference jump;

    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        gameManager = gameController.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(gameManager.moveVector * gameManager.moveSpeed *gameManager.playerAcceleration * Time.deltaTime);
    }
}
