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
       
        if (other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && (GameManager.instance.contador < 6 || GameManager.instance.contador < 10 && GameManager.instance.contador > 12)) //NORMAL
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
        else if (other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && GameManager.instance.contador == 6)
        {
            alreadyTriggered = true;
            GameObject randomChunk = ChunkEntradaPortal[Random.Range(0, ChunkEntradaPortal.Length)];

            //randomChunk.transform.position = new Vector3(-1.151364f, 0.451f, -0.1264174f);
            //Final = this.gameObject.transform.GetChild(5).gameObject;
            Instantiate(randomChunk, UltimoCube.transform.position, Quaternion.identity);
            //Instantiate(Final);

            trigger.SetActive(false);

            GameManager.instance.contador++;
            Debug.Log(GameManager.instance.contador);
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && GameManager.instance.contador > 6 && GameManager.instance.contador < 10)
        {
            //ENTRE PORTALES
        }

        else if(other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && GameManager.instance.contador == 10)
        {
            //SALIDA PORTALES
        }

        else if(other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && GameManager.instance.contador < 10 && GameManager.instance.contador > 12)
        {
            //NORMAL
        }
        else if(other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && GameManager.instance.contador == 13)
        {
            //META
        }
    }
}
