using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuNiveles : MonoBehaviour
{
    [SerializeField] Button Nivel1;
    [SerializeField] Button Nivel2;
    [SerializeField] Button Nivel3;
    [SerializeField] Button EscenaAnterior;

    [SerializeField] Button PortalButton;

    [SerializeField] string Level1;
    [SerializeField] string Tutorial;
    [SerializeField] string Level2;
    [SerializeField] string VolverMenu;
    [SerializeField] string PortalEscena;

    [SerializeField] GameObject canvasPortal;

    public void OnEnable()
    {
        Nivel1.onClick.AddListener(EscenaNivel1);
        Nivel2.onClick.AddListener(EscenaTutorial);
        Nivel3.onClick.AddListener(EscenaNivel2);

        PortalButton.onClick.AddListener(EscenaPortal);

        EscenaAnterior.onClick.AddListener(LastScene);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            canvasPortal.SetActive(true);
        }
    }

    void EscenaTutorial()
    { 
        SceneManager.LoadScene(Tutorial);
        Time.timeScale = 1f;
    }
    void EscenaNivel1()
    { 
        SceneManager.LoadScene(Level1);
        Time.timeScale = 1f;
    }
    
    void EscenaNivel2()
    { SceneManager.LoadScene(Level2); }

    void EscenaPortal()
    { 
        SceneManager.LoadScene(PortalEscena);
        Time.timeScale = 1f;
    }

    void LastScene()
    { 
        SceneManager.LoadScene(VolverMenu);
        Time.timeScale = 1f;
    }
}
