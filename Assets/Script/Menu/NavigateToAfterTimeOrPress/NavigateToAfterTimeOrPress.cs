using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class NavigateToAfterTimeOrPress : MonoBehaviour
{
    [SerializeField] InputActionReference skip;
    public float wait = 5f;
    [SerializeField] string NextScreen;
    bool sceneCall;
    public void NavigateToNextScreen()
    {
       if(sceneCall)
       {
            SceneManager.LoadScene(NextScreen);
       }       
    }

    private void Awake()
    {
        Invoke("NavigateToNextScreen",wait);
    }
    void Start()
    {
        sceneCall = true;
    }

    void Update()
    {       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NavigateToNextScreen(); 
        }
    }
}