using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFunctions : MonoBehaviour
{
    //Variables
    public Slider pressureSlider;

    Color[] colours = new Color[4] { Color.white, Color.blue, Color.green, Color.red };
    Button theButt;

    //Functions
    public void SetPressureSlider(int value) 
    {
        pressureSlider.value = value;
    }

    public void ButtonAssign(Button butt) 
    {
         theButt = butt;
    }

    public void SetNextColour(int i) 
    {
        theButt.GetComponent<Button>().image.color = colours[i];
    }
}
