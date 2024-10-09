using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class GameManager : MonoBehaviour
{

    public PlayerController playerController;
    public float playerAcceleration;

    public TMP_Text scoreDead;
    private int deathCount = 1;

    void Start()
    {
        //scoreDead = GetComponent<TMP_Text>();
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            playerController.Respawn();
            playerController.AccelerationNull();
            scoreDead.text = $" ATTEMPT  {deathCount}";
            Debug.Log(deathCount);
            deathCount++;
            

        }
    }
}
