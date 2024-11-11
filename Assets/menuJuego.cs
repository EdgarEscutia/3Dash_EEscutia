using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuJuego : MonoBehaviour
{
    [Header("CANVAS")]
    [SerializeField] Canvas MenuInGame;

    [Header("BUTTONS")]
    [SerializeField] Button Resume;
    [SerializeField] Button Menu;
    [SerializeField] Button Salir;


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