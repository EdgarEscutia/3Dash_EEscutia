using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_enter : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 6)
        {
            
        }
    }
}
