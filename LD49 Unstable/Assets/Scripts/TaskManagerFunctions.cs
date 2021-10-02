using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManagerFunctions : MonoBehaviour
{

    //Variables
    public GameObject commander;
    public GameObject switchModule;
    public GameObject eqModule;

    //puzzle vars
    int[] switchCombination = new int[5];
    int[] eqCombination = new int[7];

    //Player vars
    int[] sPlayerCombination = new int[5];
    int[] ePlayerCombination = new int[7];

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
            default:
                Debug.Log("No Task Given");
                break;
        }

    }

    //Task Creators
    //TODO: Make these not just the first combo!!
    void CreateSwitchTask()
    {
        switchCombination = switchModule.GetComponent<SwitchModuleFunctions>().SetCombination(switchModule.GetComponent<SwitchModuleFunctions>().combinations[0]);
    }

    void CreateEQTask() 
    {
        eqCombination = eqModule.GetComponent<EQModuleFunctions>().SetCombination(eqModule.GetComponent<EQModuleFunctions>().combinations[0]);
    }

    //Task Completors
    //TODO: Connect completes to buttons in UI
    void CompleteSwitchTask() 
    {
        sPlayerCombination = switchModule.GetComponent<SwitchModuleFunctions>().CommitCombination();
        if (sPlayerCombination == switchCombination) { commander.GetComponent<CommanderFunctions>().RegisterCommandComplete(); }
    }

    void CompleteEQTask()
    {
        ePlayerCombination = eqModule.GetComponent<EQModuleFunctions>().CommitCombination();
        if (ePlayerCombination == eqCombination) { commander.GetComponent<CommanderFunctions>().RegisterCommandComplete(); }
    }



}
