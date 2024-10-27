using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGererateChunks : MonoBehaviour
{

    public GameObject[] Chunks;

    private void Start()
    {
        int randomNumber =  Random.Range(0, Chunks.Length);

        GameObject randomChunk = Chunks[randomNumber];

        Instantiate(randomChunk);

    }
}
