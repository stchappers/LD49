using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TaskManagerFunctions : MonoBehaviour
{

    //Variables
    public GameObject commander;
    public GameObject switchModule;
    public GameObject eqModule;
    public GameObject pressureModule;
    public GameObject lightPadModule;

    //puzzle vars
    int[] switchCombination = new int[5];
    int[] eqCombination = new int[7];
    int[] lightPadCombination = new int[16];
    int pressureValue;


    //Player vars
    int[] sPlayerCombination = new int[5];
    int[] ePlayerCombination = new int[7];
    int pPlayerCombination;
    int[] lPlayerCombination = new int[16];

    //Functions
    public void GenerateTask(string taskType)
    {
        switch (taskType)
        {
            case "switch":
                CreateSwitchTask();
                break;
            case "EQ":
                CreateEQTask();
                break;
            case "pressure":
                CreatePressureTask();
                break;
            case "lightpad":
                CreateLightPadTask();
                break;
            default:
                Debug.Log("No Task Given");
                break;
        }

    }

    int PuzzleVariationSelection() 
    {
        int selection = 0;
        selection = Random.Range(0, 5);
        return selection;

    }

    //Task Creators
    void CreateSwitchTask()
    {
        switchCombination = switchModule.GetComponent<SwitchModuleFunctions>().SetCombination(switchModule.GetComponent<SwitchModuleFunctions>().combinations[PuzzleVariationSelection()]);
    }

    void CreateEQTask() 
    {
        eqCombination = eqModule.GetComponent<EQModuleFunctions>().SetCombination(eqModule.GetComponent<EQModuleFunctions>().combinations[PuzzleVariationSelection()]);
    }

    void CreatePressureTask() 
    {
        pressureValue = pressureModule.GetComponent<PressureModuleFunctions>().SetPressure(pressureModule.GetComponent<PressureModuleFunctions>().pressures[PuzzleVariationSelection()]);
    }

    void CreateLightPadTask() 
    {
        lightPadCombination = lightPadModule.GetComponent<LightPadModuleFunctions>().SetCombination(lightPadModule.GetComponent<LightPadModuleFunctions>().combinations[PuzzleVariationSelection()]);
    }

    //Task Completors
    public void CompleteSwitchTask() 
    {
        sPlayerCombination = switchModule.GetComponent<SwitchModuleFunctions>().CommitCombination();
        if (sPlayerCombination.SequenceEqual(switchCombination)) { commander.GetComponent<CommanderFunctions>().RegisterCommandComplete(); }
    }

    public void CompleteEQTask()
    {
        ePlayerCombination = eqModule.GetComponent<EQModuleFunctions>().CommitCombination();
        if (ePlayerCombination.SequenceEqual(eqCombination)) { commander.GetComponent<CommanderFunctions>().RegisterCommandComplete(); }
    }

    public void CompletePressureTask() 
    {
        pPlayerCombination = pressureModule.GetComponent<PressureModuleFunctions>().CommitPressure();
        if (pPlayerCombination == pressureValue) { commander.GetComponent<CommanderFunctions>().RegisterCommandComplete(); }
    }

    public void CompleteLightPadTask() 
    {
        lPlayerCombination = lightPadModule.GetComponent<LightPadModuleFunctions>().CommitCombination();
        if (lPlayerCombination.SequenceEqual(lightPadCombination)) { commander.GetComponent<CommanderFunctions>().RegisterCommandComplete(); }
    }

}
