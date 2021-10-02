using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureModuleFunctions : MonoBehaviour
{
    //Variables
    public GameObject UIHelper;
    public int enteredPressure;


    //Functions
    public void SetPressureIO(int button) 
    {
        switch (button)
        {
            case 0:
                enteredPressure -= 10;
                break;
            case 1:
                enteredPressure -= 3;
                break;
            case 2:
                enteredPressure += 5;
                break;
            case 3:
                enteredPressure += 7;
                break;
            default:
                Debug.Log("No Button pressed, how did you get here?");
                break;

        }

        if (enteredPressure <= 0) { enteredPressure = 0; }
        if (enteredPressure >= 100) { enteredPressure = 100; }
        UIHelper.GetComponent<UIFunctions>().SetPressureSlider(enteredPressure);

    }

    public int SetPressure(int pressure)
    {
        int chosenPressure;
        chosenPressure = pressure;
        return chosenPressure;
    }

    public int CommitPressure()
    {
        return enteredPressure;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
