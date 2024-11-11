using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuJuego : MonoBehaviour
{
    [Header("CANVAS")]
    [SerializeField] Canvas MenuInGame;
    public void Restart()
    {
        MenuInGame.gameObject.SetActive(false);

        Time.timeScale = 1f;
    }
    public void Pause()
    {
        MenuInGame.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
}