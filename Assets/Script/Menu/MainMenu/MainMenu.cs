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

    public GameObject PantallaDeCarga;
    public Slider slider;


    public void OnEnable()
    {
  
        salir.onClick.AddListener(EscenaSalir);
    }

    public void CargarNivel(int NumeroDeEscena)
    {
        StartCoroutine(CargarAsync(NumeroDeEscena));
    }

    void EscenaSalir()
    {
        Application.Quit();
        //EditorApplication.isPlaying = false;
    }

    IEnumerator CargarAsync(int NumeroDeEscena)
    {
        AsyncOperation Operacion = SceneManager.LoadSceneAsync(NumeroDeEscena);
    
        PantallaDeCarga.SetActive(true);

        while (!Operacion.isDone)
        {
            float Progreso = Mathf.Clamp01(Operacion.progress/ 0.9f);
            slider.value = Progreso;
            yield return null;
        }
    
    }
}
