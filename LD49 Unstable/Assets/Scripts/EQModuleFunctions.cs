using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EQModuleFunctions : MonoBehaviour
{

    //Variables
    public int[][] combinations = new int[5][];
    public int[] enteredCombination = new int[7];

    int sliderValue;

    // Start is called before the first frame update
    void Start()
    {
        //Setting the combinations
        combinations[0] = new int[7] { 9, 3, 6, 7, 5, 6, 8 };
        combinations[1] = new int[7] { 4, 9, 6, 7, 5, 6, 7 };
        combinations[2] = new int[7] { 3, 9, 7, 5, 6, 9, 5 };
        combinations[3] = new int[7] { 9, 8, 7, 5, 4, 6, 7 };
        combinations[4] = new int[7] { 4, 5, 6, 8, 6, 7, 8 };

        //for (int i = 0; i < combinations[1].Length; i++) { Debug.Log(combinations[1][i].ToString()); }
    }

    public int[] SetCombination(int[] combination)
    {
        int[] chosenCombination = new int[7];
        chosenCombination = combination;
        return chosenCombination;
    }

    public void SetEQIO(float slider) 
    {
        sliderValue = (int)slider;
    }

    public void SetEQIOP(int position) 
    {
        enteredCombination[position] = sliderValue;
    }

    public int[] CommitCombination()
    {
        return enteredCombination;
    }

}
