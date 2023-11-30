using System;
using System.Collections.Generic;

class Program
{
    static List<string> array1 = new List<string> { "abc", "abcde", "55", "adsfa", "321" };
    static List<string> array2 = new List<string>();
    
    static void Main(string[] args)
    {
        Sort();
        Console.WriteLine(string.Join(", ", array2));
    }
    
    static void Sort()
    {
        int index = 0;
        for (int i = 0; i < array1.Count; i++)
        {
            if (array1[index].Length <= 3)
            {
                array2.Add(array1[index]);
                index = index + 1;
            }
        }
    }
}
