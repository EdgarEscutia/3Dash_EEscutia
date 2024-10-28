using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGererateChunks : MonoBehaviour
{

    public GameObject[] Chunks;
    public GameObject UltimoCube;
    public GameObject[] LastChunk;

    public void AutoGenerate()
    {

        int randomNumber = Random.Range(0, Chunks.Length);
        
        GameObject randomChunk = Chunks[randomNumber];

        //randomChunk.transform.position = new Vector3(-1.151364f, 0.451f, -0.1264174f);
        //Final = this.gameObject.transform.GetChild(5).gameObject;
       Instantiate(randomChunk, UltimoCube.transform.position,Quaternion.identity);
        //Instantiate(Final);

    }


    public void AutoGenerateMeta()
    {
        int randomNumber = Random.Range(0, LastChunk.Length);

        //randomChunk.transform.position = new Vector3(-1.151364f, 0.451f, -0.1264174f);
        //Final = this.gameObject.transform.GetChild(5).gameObject;
        Instantiate(LastChunk[randomNumber], UltimoCube.transform.position, Quaternion.identity);
        //Instantiate(Final);

    }
}
