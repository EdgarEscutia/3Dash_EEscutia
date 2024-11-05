using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Optionmanager : MonoBehaviour
{
    [SerializeField] Button EscenaAnterior;

    [SerializeField] string VolverMenu;
    void Start()
    {
        EscenaAnterior.onClick.AddListener(LastScene);
    }

    void LastScene()
    { SceneManager.LoadScene(VolverMenu); }
}
