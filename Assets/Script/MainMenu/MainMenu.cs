using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button jugar;
    [SerializeField] Button opciones;
    [SerializeField] Button salir;

    [SerializeField] string Nivel1;

    public void OnEnable()
    {
        jugar.onClick.AddListener(EscenaJugar);
        opciones.onClick.AddListener(EscenaOpciones);
        salir.onClick.AddListener(EscenaSalir);
    }

    void EscenaJugar()
    {
        SceneManager.LoadScene(Nivel1);
    }
    void EscenaOpciones()
    {
        Debug.Log("Opciones");
    }
    void EscenaSalir()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
        // Update is called once per frame
    void Update()
    {
        
    }
}
