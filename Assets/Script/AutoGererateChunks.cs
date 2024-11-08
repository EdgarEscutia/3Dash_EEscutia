using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGererateChunks : MonoBehaviour
{
    public GameObject[] ChunksFaciles;
    public GameObject[] ChunksMedianos;
    public GameObject[] ChunksDificiles;

    public GameObject UltimoCube;





    public GameObject triggers;


    GameObject randomChunk;
    public void AutoGenerate()
    {
        if(GameManager.instance.contador == 0)
        {

            float randomNumber = Random.Range(0, 1);

            if (randomNumber <= 0.7f)
            {
                randomChunk = ChunksFaciles[Random.Range(0, ChunksFaciles.Length)];
            }
            else if (randomNumber > 0.7f && randomNumber <= 0.9f)
            {
                randomChunk = ChunksMedianos[Random.Range(0, ChunksMedianos.Length)];
            }
            else if (randomNumber > 0.9f)
            {
                randomChunk = ChunksDificiles[Random.Range(0, ChunksDificiles.Length)];
            }
            //randomChunk.transform.position = new Vector3(-1.151364f, 0.451f, -0.1264174f);
            //Final = this.gameObject.transform.GetChild(5).gameObject;
            Instantiate(randomChunk, UltimoCube.transform.position, Quaternion.identity);
            //Instantiate(Final);

            triggers.SetActive(false);
            //UltimoCube = 
            Debug.Log("Entra Autogenerate");
            GameManager.instance.contador = 6;
        }

    }

    public void Update()
    {

    }
}
