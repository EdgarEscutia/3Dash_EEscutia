using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraPortal : MonoBehaviour
{
    public Image VidaPortal;

    public float VidaActual;

    public Canvas Canvas_BarraPortal;

    public bool muerto = false;


    // Start is called before the first frame update

    public void DesactivarBarra()
    {
        Canvas_BarraPortal.gameObject.SetActive(false);
    }
    public void ActivarBarraPortal()
    {
        Canvas_BarraPortal.gameObject.SetActive(true);
        VidaActual = 100;
        muerto = false;
    }
    public void AñadirVidaPortal()
    {
        VidaActual += 50f;
        VidaPortal.fillAmount = VidaActual / 100f;
    }
    public void QuitarVidaPortal()
    {
        VidaActual -= 25f;
        VidaPortal.fillAmount = VidaActual / 100f;
    }
    // Update is called once per frame
    void Update()
    {
        if(Canvas_BarraPortal.gameObject.activeSelf == true)
        {
            
            VidaActual -= 10f * Time.deltaTime;
            VidaPortal.fillAmount = VidaActual / 100f;

            if (VidaActual <= 0)
            {GameManager.instance.RandomReset();}
            
        }
        
    }   
}
