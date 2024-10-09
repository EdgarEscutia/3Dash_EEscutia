using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public PlayerController playerController;
    public float playerAcceleration;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            playerController.Respawn();
            playerController.AccelerationNull();
        }
    }
}
