using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AutoSavedSlider : MonoBehaviour
{
    [SerializeField] string PrefKey;
    [SerializeField] float inicialDefaultValue;
    public void InternalIValueChanged(float value)
    {

    }

    virtual protected void Start()
    {
        InternalIValueChanged(inicialDefaultValue);
    }

    public void onValueChanged() 
    {

        InternalIValueChanged(21f); //Ha de llamar a esta fx 
                                    //El numero es de prueba
    }
    void Update()
    {
        
    }
}
