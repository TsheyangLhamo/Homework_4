using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_2 : MonoBehaviour
{
    //Call your function using an int[] array = new int[10]{1,2,3,4,5,6,7,8,9,10};
    //Your return values should be a List<int> that holds {1,3,5,7,9}
    void Start()
    {
        
    }

    //Create a function called OnlyOddOnes that takes in an int array as a parameter and returns 
    //a List of integers that were odd inside the array
    List<int> OnlyOddOnes(int[] array)
    {
        List<int> numbers = new List<int>();
        for(int i=0; i<array.Length; i++) {
            if (i % 2 != 0) { numbers.Add(i); }

                   }
        return numbers; 
    }
   
}
