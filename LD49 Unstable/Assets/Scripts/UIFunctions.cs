using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFunctions : MonoBehaviour
{
    //Variables
    public Slider pressureSlider;

    //Functions
    public void SetPressureSlider(int value) 
    {
        pressureSlider.value = value;
    }

}
