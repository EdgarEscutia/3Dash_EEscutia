using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraPortal : MonoBehaviour
{
    public Image VidaPortal;

    public float VidaActual;

    public Canvas Canvas_BarraPortal;

    public bool salta = false;


    // Start is called before the first frame update
    
    public void DesactivarBarra()
    {
        Canvas_BarraPortal.gameObject.SetActive(false);
    }
    public void ActivarBarraPortal()
    {
        Canvas_BarraPortal.gameObject.SetActive(true);
        VidaActual = 100;
        salta = false;
    }
    public void AñadirVidaPortal()
    {
        VidaActual += 30f;
        VidaPortal.fillAmount = VidaActual / 100f;
    }
    public void QuitarVidaPortal()
    {
        VidaActual -= 30f;
        VidaPortal.fillAmount = VidaActual / 100f;
    }
    // Update is called once per frame
    void Update()
    {
        if(Canvas_BarraPortal == true)
        {
            VidaActual -= 0.1f;
            VidaPortal.fillAmount = VidaActual / 100f;
            if (VidaActual <= 0 && salta == false)
            {
                GameManager.instance.SetStart();
                salta = true;

            }
        }
        
    }   
}
