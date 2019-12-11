using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CumputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField ipfVarA;
    public InputField ipfVarB;
    public Button btnSubNumbers;
    public Button btnReset;

    int index = 0;

    public void ResetOnClick()
    {
        ipfVarA.interactable = true;
        ipfVarB.interactable = true;
        btnSubNumbers.interactable = true;
        btnReset.interactable = false;

        result.text = "Result";
        ipfVarA.text = "";
        ipfVarB.text = "";
    }


    public void SubNumbersOnClick()
    {
        int variableA = int.Parse(ipfVarA.text);
        int variableB = int.Parse(ipfVarB.text);
        int subResult = variableA - variableB;
        result.text = subResult.ToString();

        ipfVarA.interactable = false;
        ipfVarB.interactable = false;
        btnSubNumbers.interactable = false;
        btnReset.interactable = true;
    }
}
