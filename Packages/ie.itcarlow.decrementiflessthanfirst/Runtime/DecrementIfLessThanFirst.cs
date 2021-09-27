using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementIfLessThanFirst
{
 
    public static int decrementIfLess(int x,int n)
    {
        if (x < n)
        {
            x--;
        }
        return x;
    }

    public static int[] decrementIfLessS(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            
            result[i] = decrementIfLess(xs[i],xs[0]);
        }
        return result;
    }
}