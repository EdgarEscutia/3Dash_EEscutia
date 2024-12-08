using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button salir;
    [SerializeField] Button Jugar;
    [SerializeField] Button Opciones;
    [SerializeField] Button Creditos;

    [SerializeField] string options;
    [SerializeField] string Niveles;
    [SerializeField] string creditos;


    public void OnEnable()
    {
        Opciones.onClick.AddListener(EscenaOpciones);
        Jugar.onClick.AddListener(EscenaNiveles);
        Creditos.onClick.AddListener(EscenaCreditos);
        salir.onClick.AddListener(EscenaSalir);

    }

    void EscenaOpciones()
    { SceneManager.LoadScene(options); }
    void EscenaNiveles()
    { SceneManager.LoadScene(Niveles); }

    void EscenaCreditos()
    { SceneManager.LoadScene(creditos); }

    void EscenaSalir()
    {
        Application.Quit();
        //EditorApplication.isPlaying = false;
    }
}
