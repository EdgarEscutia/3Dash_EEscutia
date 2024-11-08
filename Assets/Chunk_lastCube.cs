using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Chunk_lastCube : MonoBehaviour
{
    public GameObject[] ChunksNormales;
    public GameObject[] ChunkEntradaPortal;
    public GameObject[] ChunkSalidaPortal;


    public GameObject[] ChunkMeta;

    public GameObject UltimoCube;
    public GameObject trigger;
    [SerializeField] string layerPlayer;

    bool alreadyTriggered;
    //public GameObject[] nextChunk;

    public void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && GameManager.instance.contador < 6) //OBSTACULOS
        {
            Debug.Log("Trigger activated for the first time!");

            alreadyTriggered = true;
            GameObject randomChunk = ChunksNormales[Random.Range(0, ChunksNormales.Length)];

            //randomChunk.transform.position = new Vector3(-1.151364f, 0.451f, -0.1264174f);
            //Final = this.gameObject.transform.GetChild(5).gameObject;
            Instantiate(randomChunk, UltimoCube.transform.position, Quaternion.identity);
            //Instantiate(Final);

            trigger.SetActive(false);

            GameManager.instance.contador++;
            Debug.Log(GameManager.instance.contador);

        }
        else if (other.gameObject.layer == LayerMask.NameToLayer(layerPlayer) && !alreadyTriggered && GameManager.instance.contador == 6)
        {
            //ENTRADA PORTALES
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
        

        //if (opcion == 1)
        //{
        //    GameObject randomChunk = Chunks[Random.Range(0, Chunks.Length)];

            //    //randomChunk.transform.position = new Vector3(-1.151364f, 0.451f, -0.1264174f);
            //    //Final = this.gameObject.transform.GetChild(5).gameObject;
            //    Instantiate(randomChunk, UltimoCube.transform.position, Quaternion.identity);
            //    //Instantiate(Final);

            //    trigger.SetActive(false);
            //    opcion = 0;

            //}

    }
}
