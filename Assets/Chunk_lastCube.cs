using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Chunk_lastCube : MonoBehaviour
{
    public GameObject[] ChunksFaciles;
    public GameObject[] ChunksMedianos;
    public GameObject[] ChunksDificiles;


    public GameObject[] ChunkEntradaPortal;
    public GameObject[] ChunkSalidaPortal;
    public GameObject[] ChunkEntrePortal;
    
    public GameObject[] ChunkMeta;

    public GameObject UltimoCube;
    public GameObject trigger;
    [SerializeField] string layerPlayer;


    GameObject randomChunk;

    bool alreadyTriggered;

    public void OnTriggerEnter(Collider other)
    {
        //NORMAL
        if (other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && GameManager.instance.contador < 4) //NORMAL
        {
            
            float randomNumber = Random.Range(0, 1);
            alreadyTriggered = true;



            // % DE DIFICULTAD
            if(randomNumber <= 0.7f)
            {
                randomChunk = ChunksFaciles[Random.Range(0, ChunksFaciles.Length)];
            }
            else if(randomNumber > 0.7f && randomNumber <= 0.9f)
            {
                randomChunk = ChunksMedianos[Random.Range(0, ChunksMedianos.Length)];
            }
            else if(randomNumber > 0.9f)
            {
                randomChunk = ChunksDificiles[Random.Range(0, ChunksDificiles.Length)];
            }
            

            
            Instantiate(randomChunk, UltimoCube.transform.position, Quaternion.identity);

            trigger.SetActive(false);

            GameManager.instance.contador++;
            //Debug.Log(GameManager.instance.contador);

        }
        //ENTRADA PORTAL
        else if (other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && GameManager.instance.contador == 4)
        {
            alreadyTriggered = true;
            GameObject randomChunk = ChunkEntradaPortal[Random.Range(0, ChunkEntradaPortal.Length)];

            Instantiate(randomChunk, UltimoCube.transform.position, Quaternion.identity);

            trigger.SetActive(false);

            GameManager.instance.contador++;
            Debug.Log(GameManager.instance.contador);
        }
        //ENTRE PORTALES
        else if (other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && GameManager.instance.contador > 4 && GameManager.instance.contador < 7)
        {

            alreadyTriggered = true;

            randomChunk = ChunkEntrePortal[Random.Range(0, ChunkEntrePortal.Length)];

            Instantiate(randomChunk, UltimoCube.transform.position, Quaternion.identity);

            trigger.SetActive(false);

            GameManager.instance.contador++;
        }
        //SALIDA PORTAL
        else if(other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && GameManager.instance.contador == 7)
        {
            alreadyTriggered = true;

            randomChunk = ChunkSalidaPortal[Random.Range(0, ChunkSalidaPortal.Length)];

            Instantiate(randomChunk, UltimoCube.transform.position, Quaternion.identity);

            trigger.SetActive(false);

            GameManager.instance.contador++;
        }
        //NORMAL
        else if(other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && GameManager.instance.contador > 7 && GameManager.instance.contador < 9)
        {
            float randomNumber = Random.Range(0, 1);
            alreadyTriggered = true;



            // % DE DIFICULTAD
            if (randomNumber <= 0.5f)
            {
                randomChunk = ChunksFaciles[Random.Range(0, ChunksFaciles.Length)];
            }
            else if (randomNumber > 0.5f && randomNumber <= 0.7f)
            {
                randomChunk = ChunksMedianos[Random.Range(0, ChunksMedianos.Length)];
            }
            else if (randomNumber > 0.7f)
            {
                randomChunk = ChunksDificiles[Random.Range(0, ChunksDificiles.Length)];
            }



            Instantiate(randomChunk, UltimoCube.transform.position, Quaternion.identity);

            trigger.SetActive(false);

            GameManager.instance.contador++;
        }
        //META
        else if(other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && GameManager.instance.contador == 9)
        {
            alreadyTriggered = true;

            randomChunk = ChunkMeta[Random.Range(0, ChunkMeta.Length)];

            Instantiate(randomChunk, UltimoCube.transform.position, Quaternion.identity);

            trigger.SetActive(false);

            GameManager.instance.contador++;
        }
    }
}
