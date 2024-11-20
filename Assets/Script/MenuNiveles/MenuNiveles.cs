using System.Collections;
using System.Collections.Generic;
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

    [SerializeField] string Level1;
    [SerializeField] string Tutorial;
    //[SerializeField] string Level3;
    [SerializeField] string VolverMenu;
    public void OnEnable()
    {
        Nivel1.onClick.AddListener(EscenaNivel1);
        Nivel2.onClick.AddListener(EscenaTutorial);
        Nivel3.onClick.AddListener(EscenaNivel3);
        EscenaAnterior.onClick.AddListener(LastScene);
    }


    void EscenaTutorial()
    { SceneManager.LoadScene(Tutorial);}
    void EscenaNivel1()
    { SceneManager.LoadScene(Level1); }
    
    void EscenaNivel3()
    { /*SceneManager.LoadScene(Level3);*/ }

    void LastScene()
    { SceneManager.LoadScene(VolverMenu); }
}
