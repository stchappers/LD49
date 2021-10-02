using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPadModuleFunctions : MonoBehaviour
{
    //Variables
    public GameObject UIHelper; 
    public int[][] combinations = new int[5][];
    public int[] enteredSequence = new int[16];

    // Start is called before the first frame update
    void Start()
    {
        //Setting the combinations
        combinations[0] = new int[16] { 0, 1, 0, 3, 0, 2, 0, 1, 2, 3, 1, 0, 2, 0, 3, 2 };
        combinations[1] = new int[16] { 0, 1, 0, 2, 3, 0, 2, 1, 0, 2, 3, 0, 1, 2, 3, 0 };
        combinations[2] = new int[16] { 2, 0, 1, 3, 0, 2, 0, 1, 3, 0, 3, 0, 2, 1, 0, 2 };
        combinations[3] = new int[16] { 1, 2, 0, 0, 3, 0, 2, 1, 0, 2, 3, 0, 1, 2, 0, 3 };
        combinations[4] = new int[16] { 1, 2, 0, 3, 0, 2, 0, 2, 1, 1, 0, 1, 0, 3, 3, 0 };

    }

    //Functions
    public int[] SetCombination(int[] combination)
    {
        int[] chosenCombination = new int[16];
        chosenCombination = combination;
        return chosenCombination;
    }

    public void SetPadIO(int pad)
    {
        enteredSequence[pad] += 1;
        if (enteredSequence[pad] >= 4) { enteredSequence[pad] = 0; }
        UIHelper.GetComponent<UIFunctions>().SetNextColour(enteredSequence[pad]);
    }

    public int[] CommitCombination()
    {
        return enteredSequence;
    }
}
