using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicManager : MonoBehaviour
{
    //Variables
    public GameObject commander;
    public GameObject switchModule;
    int chosenCommand;
    bool commandIssued;

    //Functions
    public void GenerateCommand() 
    {
        if (commandIssued == false)
        {
            //TODO: Link commands to the actions you have to complete!
            chosenCommand = Random.Range(0, commander.GetComponent<CommandReader>().gameCommandList.commands.Length);
            commander.GetComponent<CommanderFunctions>().GiveCommand(chosenCommand);
            commandIssued = true;
        }
        else { Debug.Log("command already issued!"); }

    }

    public void GenerateTask() 
    {
        //TODO: Link to the commands (which commands require which tasks?

    }

    void SwitchTask() 
    {
        switchModule.GetComponent<SwitchModuleFunctions>().SetCombination(switchModule.GetComponent<SwitchModuleFunctions>().combinations[0]);
    }

    public void CompleteCommand() 
    {
        commander.GetComponent<CommanderFunctions>().RegisterCommandComplete();
        commandIssued = false;
    }
}
