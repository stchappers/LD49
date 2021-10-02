using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManagerFunctions : MonoBehaviour
{

    //Variables
    public GameObject commander;
    public GameObject switchModule;

    //puzzle vars
    int[] switchCombination = new int[5];

    //Player vars
    int[] playerCombination = new int[5];

    //Functions
    public void GenerateTask(string taskType)
    {
        switch (taskType)
        {
            case "switch":
                CreateSwitchTask();
                break;
            default:
                Debug.Log("No Task Given");
                break;
        }

    }

    //Task Creators
    void CreateSwitchTask()
    {
        switchCombination = switchModule.GetComponent<SwitchModuleFunctions>().SetCombination(switchModule.GetComponent<SwitchModuleFunctions>().combinations[0]);
    }

    //Task Completors
    //TODO: Connect completes to buttons in UI
    void CompleteSwitchTask() 
    {
        playerCombination = switchModule.GetComponent<SwitchModuleFunctions>().CommitCombination();
        if (playerCombination == switchCombination) { commander.GetComponent<CommanderFunctions>().RegisterCommandComplete(); }
    }



}
