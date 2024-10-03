using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Create a variable of type interger
    int myint = 28;


    // Start is called before the first frame update
    void Start()
    {

        //I am going to run myint thru my function to mutiply it by two 
        myint = MutiplyByTwo(myint);

        //I'm going to 

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Creating a function that takes a int parameter and mutiplies by 2 
    int MutiplyByTwo(int number)
    {
        //creating a variable to store my results
        int results;
        ///mutiplying the passed parameter by 2
        results = number * 2;

        //Returning the results
        return results;
    }
}