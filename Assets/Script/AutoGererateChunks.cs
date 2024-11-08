using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGererateChunks : MonoBehaviour
{

    public GameObject[] Chunks;
    public GameObject UltimoCube;
    public GameObject[] LastChunk;
    public GameObject[] NextChunks;

    public GameObject triggers;


    Chunk_lastCube LastCube;
    int randomNumber1;
    int randomNumber2;

    public void AutoGenerate()
    {
        if(GameManager.instance.contador == 0)
        {
            randomNumber1 = Random.Range(0, Chunks.Length);

            GameObject randomChunk = Chunks[randomNumber1];

            //randomChunk.transform.position = new Vector3(-1.151364f, 0.451f, -0.1264174f);
            //Final = this.gameObject.transform.GetChild(5).gameObject;
            Instantiate(randomChunk, UltimoCube.transform.position, Quaternion.identity);
            //Instantiate(Final);

            triggers.SetActive(false);
            //UltimoCube = 
            Debug.Log("Entra Autogenerate");

        }

    }

    public void Update()
    {

    }
}
