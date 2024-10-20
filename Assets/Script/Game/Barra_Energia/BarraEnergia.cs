using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraEnergia : MonoBehaviour
{
    public Image Energia; //Barra de Energia

    public float EnergiaActual; //Energia del player

    public Canvas Canvas_EnergiaParticulas; //Canvas activable

    public Canvas Boton_Particulas;

    bool start= false;

    public void ActivarBoton()
    {
        Boton_Particulas.gameObject.SetActive(true);
    }
    public void Start()
    {
        Boton_Particulas.gameObject.SetActive(false);
        Canvas_EnergiaParticulas.gameObject.SetActive(false);
        EnergiaActual = 100;
        start = false;
    }
    public void Restart_Barra()
    {
        Boton_Particulas.gameObject.SetActive(false);
        Canvas_EnergiaParticulas.gameObject.SetActive(false);
        EnergiaActual = 100;
        Energia.fillAmount = EnergiaActual / 100f;
        start = false;
    }

    public void activarBarra()
    {
        Boton_Particulas.gameObject.SetActive(false);
        Canvas_EnergiaParticulas.gameObject.SetActive(true);
        Energia.fillAmount = EnergiaActual / 100f;
        start = true;
    }
    void Update()
    {
        if(start)
        {
            EnergiaActual -= 0.2f;
            Energia.fillAmount = EnergiaActual / 100f;
        }
        if(EnergiaActual <= 0)
        {
            Restart_Barra();
            GameManager.instance.RestartCameras();
        }

        
    }
}
