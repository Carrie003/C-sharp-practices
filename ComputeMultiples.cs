using System;
using System.Collections.Generic;



//Compute the sum of all multiples of 3 and 5 under 1000

//An interesting practice of data structures and algorithm using C#



class ComputeMultiples
{

    static void Main()
    {
        int bar = 1000;
        int[] numbers = { 3, 5 };
        int sum;
        Dictionary<int, int> multiplelist = new Dictionary<int, int>();

        compute(bar, numbers, multiplelist);
        sum = SumMultiples(multiplelist);
        Console.WriteLine("The sum is " + sum);
    }


    static void compute(int limit, int[] numbers, Dictionary<int, int> multiples)
    {
        foreach (int num in numbers)
        {
            for (int i = 1; i < limit; i++)
            {
                int current = num * i;
                if (current >= limit)
                {
                    break;
                }
                if (!multiples.ContainsKey(current))
                {
                    multiples.Add(current, current);
                }
            }
        }
    }

 
    static int SumMultiples(Dictionary<int, int> multiplelist)
    {
        int sum = 0;
        foreach (KeyValuePair<int, int> pair in multiplelist)
        {
            sum += pair.Key;
        }
        return sum;
    }

   
    
}
