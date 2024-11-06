using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk_lastCube : MonoBehaviour
{
    public GameObject[] Chunks;
    public GameObject UltimoCube;
    public GameObject trigger;
    //public GameObject[] nextChunk;

    public void OnTriggerEnter()
    {        
        GameObject randomChunk = Chunks[Random.Range(0, 1)];

        //randomChunk.transform.position = new Vector3(-1.151364f, 0.451f, -0.1264174f);
        //Final = this.gameObject.transform.GetChild(5).gameObject;
        Instantiate(randomChunk, UltimoCube.transform.position, Quaternion.identity);
        //Instantiate(Final);

        trigger.SetActive(false);
        
    }
}
