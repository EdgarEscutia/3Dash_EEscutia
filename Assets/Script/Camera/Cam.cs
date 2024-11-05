using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;
    void Start()
    {
        currentView = transform;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            currentView = views[0];                    
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentView = views[1];
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            currentView = views[2];
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentView = views[3];
        }

    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);
    }
}
