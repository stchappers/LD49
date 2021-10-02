using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommanderFunctions : MonoBehaviour
{
    //Variables
    //TODO: Add start function where this auto adds this objects reader component.
    public CommandReader commander;


    //Functions
    public void GiveCommand(int chosenCommand)
    {
        //TODO: Get task from GameLogicManager
        Debug.Log(commander.GetComponent<CommandReader>().gameCommandList.commands[chosenCommand].instruction);
    }

    public void RegisterCommandComplete() 
    {
        Debug.Log("Task Complete!");
    }
}
