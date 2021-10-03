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

    int nOfTasks = 0;

    //TODO: Add current task lists


    //Functions
    public void GiveCommand(int chosenCommand)
    {
        //delivers instruction to player
        Debug.Log(commander.GetComponent<CommandReader>().gameCommandList.commands[chosenCommand].instruction);

        //sends request to create task
        taskManager.GetComponent<TaskManagerFunctions>().GenerateTask(commander.GetComponent<CommandReader>().gameCommandList.commands[chosenCommand].taskType);
        nOfTasks += 1;
    }

    public void RegisterCommandComplete() 
    {
        Debug.Log("Task Complete!");
        nOfTasks -= 1;

        if (nOfTasks <= 0) { logicManager.GetComponent<GameLogicManager>().CompleteWave(); }
    }
}
