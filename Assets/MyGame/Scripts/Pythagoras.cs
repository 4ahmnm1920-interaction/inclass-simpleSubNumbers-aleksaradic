using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pythagoras : MonoBehaviour
{

    public int value;

    public float a;
    public float b;

    void Start()
    {
        //int result = MultiplySelf(value) + MultiplySelf(value);
        //Debug.Log("Addition of Squares: " + result);

        float result = Pyth(a, b) + Pyth(a, b);
        Debug.Log("Result: " + result);
    }

    private void OnValidate()
    {
        //MultiplySelf(value);

        Pyth(a, b);
    }

    int MultiplySelf(int a)
    {
        Debug.Log("Squareresult: " + a * a);
        return (a * a);
    }

    float Pyth(float a, float b)
    {
        float cSquare;
        cSquare = (a * a) + (b * b);
        Debug.Log("cSquare: " + cSquare);
        float c = Mathf.Sqrt(cSquare);
        Debug.Log("c: " + c);
        return c;
    }

}
