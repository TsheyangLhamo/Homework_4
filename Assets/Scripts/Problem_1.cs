using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_1 : MonoBehaviour
{
    //Call your custom functions and print out the returns values of boxes 12,4 and 13.5f by 1.3f.
    //You should have 48 and 17.55 as your return print outs. 
    void Start()
    {
        parameter(12, 4);  
    }

    //Part 1: 
    //Create a function called Perimeter that takes in two parameters of int length and int width
    //Calculate the perimeter of the box and return the value as an int.

    int parameter(int width, int length) { return width + width + length + length; }
    //Part 2: 
    //Overload the function by creating a float version of the same function
    float parameter (float width, float length) { return width + width + length + length; }
}           
