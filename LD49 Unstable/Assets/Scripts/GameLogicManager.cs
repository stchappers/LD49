using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicManager : MonoBehaviour
{
    //Variables
    public GameObject commander;
    int chosenCommand;
    bool commandIssued;

    //Functions
    public void GenerateCommand() 
    {
        if (commandIssued == false)
        {
            chosenCommand = Random.Range(0, commander.GetComponent<CommandReader>().gameCommandList.commands.Length);
            commander.GetComponent<CommanderFunctions>().GiveCommand(chosenCommand);
            commandIssued = true;
        }
        else { Debug.Log("command already issued!"); }

    }



    public void CompleteCommand() 
    {
        commandIssued = false;
    }
}
