using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ChangeScreen : MonoBehaviour
{
    [SerializeField] InputActionReference skip;
    public float wait = 5f;
    [SerializeField] string MainMenu;
    bool sceneCall;


    public void NavigateToNextScreen()
    {
        if (sceneCall)
        {
            SceneManager.LoadScene(MainMenu);
            Debug.Log("MainMenu");
        }
    }

    private void Awake()
    {
        Invoke("NavigateToNextScreen", wait);
    }
    void Start()
    {
        sceneCall = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
