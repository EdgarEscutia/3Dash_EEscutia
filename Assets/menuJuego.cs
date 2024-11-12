using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuJuego : MonoBehaviour
{
    [Header("CANVAS")]
    [SerializeField] Canvas MenuInGame;

    [Header("BUTTONS")]
    [SerializeField] Button Resume;
    [SerializeField] Button Menu;
    [SerializeField] Button Salir;

    [Header("NOMBRE LVL's")]
    [SerializeField] string MenuPrincipal;

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

    public void OnEnable()
    {
        Resume.onClick.AddListener(Restart);
        Menu.onClick.AddListener(EscenaMenu);
        Salir.onClick.AddListener(EscenaSalir);

    }
    public void EscenaMenu()
    { SceneManager.LoadScene(MenuPrincipal); }

    void EscenaSalir()
    {
        Application.Quit();
        //EditorApplication.isPlaying = false;
    }
}