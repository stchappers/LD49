using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommanderFunctions : MonoBehaviour
{
    //Variables
    public GameObject logicManager;
    //TODO: Add start function where this auto adds this objects reader component.
    public CommandReader commander;
    public GameObject taskManager;

    //TODO: Add current task lists


    //Functions
    public void GiveCommand(int chosenCommand)
    {
        //delivers instruction to player
        Debug.Log(commander.GetComponent<CommandReader>().gameCommandList.commands[chosenCommand].instruction);
        Debug.Log(commander.GetComponent<CommandReader>().gameCommandList.commands[chosenCommand].taskType);

        //sends request to create task
        taskManager.GetComponent<TaskManagerFunctions>().GenerateTask(commander.GetComponent<CommandReader>().gameCommandList.commands[chosenCommand].taskType);
    }

    public void RegisterCommandComplete() 
    {
        Debug.Log("Task Complete!");
        logicManager.GetComponent<GameLogicManager>().CompleteCommand();
    }
}
