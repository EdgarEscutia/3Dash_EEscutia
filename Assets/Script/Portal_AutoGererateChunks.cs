using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Portal_AutoGererateChunks : MonoBehaviour
{
    public static Portal_AutoGererateChunks instance /*{ get { return new Portal_AutoGererateChunks();  } }*/;

    public GameObject[] ChunksEntradaPortal;

    public GameObject UltimoCube;

    public GameObject triggers;


    GameObject randomChunk;

    void Awake()
    {
        instance = this;
    }

    public void AutoGeneratePortal()
    {
        //Debug.Log("Entra Autogenerate Portales");
        
        if (GameManager.instance.contador == 0)
        {
            randomChunk = ChunksEntradaPortal[Random.Range(0, ChunksEntradaPortal.Length)];
        
            Instantiate(randomChunk, UltimoCube.transform.position, Quaternion.identity);

            triggers.SetActive(false);

            //Debug.Log("Entra Autogenerate Portales");
            GameManager.instance.contador = 5;
        }

    }
}
