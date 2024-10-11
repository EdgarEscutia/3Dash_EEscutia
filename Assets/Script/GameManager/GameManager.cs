using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{

    public PlayerController playerController;
    public float playerAcceleration;

    public TMP_Text scoreDead;
    public int deathCount = 1;

    void Start()
    {
        //scoreDead = GetComponent<TMP_Text>();
        
    }
    public void SetStart()
    {
        playerController.Respawn();
        playerController.AccelerationNull();
        scoreDead.text = $" ATTEMPT  {deathCount}";
        deathCount++;
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            SetStart();
        }
    }
}
