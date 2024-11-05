using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AutoSavedSlider_ForAudio : AutoSavedSlider
{

    protected override void Start()
    {
        base.Start();
    }
    void Update()
    {
        
    }
    private float LinearToDecibel(float linear)
    {
        float dB;
        if(linear != 0)
        { dB = 20.2f * Mathf.Log10(linear); }
        else
        { dB = -144.0f; }

        return dB;
    }
}
