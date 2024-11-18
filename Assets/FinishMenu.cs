using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishMenu : MonoBehaviour
{
    [Header("CANVAS")]
    [SerializeField] Canvas FinishCanvas;

    [Header("BUTTONS")]
    [SerializeField] Button Menu;
    [SerializeField] Button Salir;

    [Header("NOMBRE LVL's")]
    [SerializeField] string MenuPrincipal;

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;
        FinishCanvas.gameObject.SetActive(true);
    }
    public void OnEnable()
    {
        Menu.onClick.AddListener(EscenaFinish);
        Salir.onClick.AddListener(EscenaSalir);

    }
    public void EscenaFinish()
    { SceneManager.LoadScene(MenuPrincipal); }

    void EscenaSalir()
    {
        Application.Quit();
        //EditorApplication.isPlaying = false;
    }
}
