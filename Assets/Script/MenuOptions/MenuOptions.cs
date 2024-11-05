using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour
{
    [SerializeField] Button ESCMainMenu;

    [SerializeField] string LevelMenu;


    public void OnEnable()
    {
        //ESCMainMenu.onClick.AddListener(EscenaMainMenu);
    }
    void EscenaMainMenu()
    {
        SceneManager.LoadScene(LevelMenu);
    }
}
