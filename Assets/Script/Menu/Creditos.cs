using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Creditos : MonoBehaviour
{

    [SerializeField] Button EscenaAnterior;



    [SerializeField] string VolverMenu;


    public void OnEnable()
    {       
        EscenaAnterior.onClick.AddListener(LastScene);
    }
    void LastScene()
    { 
        SceneManager.LoadScene(VolverMenu);
        Time.timeScale = 1f;
    }
}
