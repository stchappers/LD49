using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandReader : MonoBehaviour
{
    public TextAsset textJSON;

    [System.Serializable]
    public class Command 
    {
        public string instruction;
        public string taskType;
    }

    [System.Serializable]
    public class CommandList 
    {
        public Command[] commands;
    }

    public CommandList gameCommandList = new CommandList();
    // Start is called before the first frame update
    void Start()
    {
        gameCommandList = JsonUtility.FromJson<CommandList>(textJSON.text);
    }

}
