using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchModuleFunctions : MonoBehaviour
{

    //Variables
    public int[][] combinations = new int[5][];
    public int[] enteredCombination = new int[5];

    // Start is called before the first frame update
    void Start()
    {
        //Setting the combinations
        combinations[0] = new int[5] { 0, 1, 0, 1, 0 };
        combinations[1] = new int[5] { 1, 1, 0, 1, 1 };
        combinations[2] = new int[5] { 0, 1, 1, 1, 0 };
        combinations[3] = new int[5] { 1, 1, 0, 1, 0 };
        combinations[4] = new int[5] { 0, 1, 0, 1, 1 };

        //for (int i = 0; i < combinations[1].Length; i++) { Debug.Log(combinations[1][i].ToString()); }
    }

    //Functions
    public int[] SetCombination(int[] combination)
    {
        int[] chosenCombination = new int[5];
        chosenCombination = combination;
        return chosenCombination;
    }

    public void SetSwitchIO(int sweetch) 
    {
        if (enteredCombination[sweetch] != 1) { enteredCombination[sweetch] = 1; }
        else { enteredCombination[sweetch] = 0; }
    }

    public int[] CommitCombination() 
    {
        return enteredCombination;
    }
}
