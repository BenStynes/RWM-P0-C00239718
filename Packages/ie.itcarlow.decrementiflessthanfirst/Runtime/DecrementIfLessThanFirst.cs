using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementIfLessThanFirst : MonoBehaviour
{
    int n =5;
    public void setN(int x)
    {
        n = x;
    }

    public int decrementIfLess(int x)
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
            if (i == 0)
            {
                setN(xs);
            }
            result[i] = decrementIfLess(xs[i]);
        }
        return result;
    }
}