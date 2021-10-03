using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicManager : MonoBehaviour
{
    //Variables
    public GameObject commander;
    public int gameTimer;

    int[] taskWaves = new int[10] { 1, 1, 1, 2, 2, 3, 3, 3, 4, 4 };
    int[] timeWaves = new int[10] { 180, 160, 120, 120, 120, 120, 100, 80, 80, 60 };

    int chosenCommand;
    bool commandIssued;

    //Functions
    void GenerateWave(int wave) 
    {
        for (int i = 0; i < taskWaves[wave]; i++)
        {
            GenerateCommand();
        }
        //TODO: Make this inform of how many tasks we have to do to pass
        gameTimer = timeWaves[wave];
    }

    public void GenerateCommand() 
    {
            //TODO: Make this not pick same task twice
            chosenCommand = Random.Range(0, commander.GetComponent<CommandReader>().gameCommandList.commands.Length);
    }



    public void CompleteWave() 
    {
        
    }
}
