using System;
using System.Collections;
using System.Numerics;

Console.WriteLine("Please Enter the Number of strings You want to sort based of their lengths");
int num_str=Convert.ToInt32(Console.ReadLine());
string[] x = new string[num_str];
int[]x1 = new int[num_str];
int[]x2= new int[num_str];
Dictionary<string, int> Sorting_array = new Dictionary<string, int>();

Console.WriteLine("Please enter the strings");
int i = 0;
while ( i < num_str)
{
    try
    {
        x[i] = Convert.ToString(Console.ReadLine());
        x1[i] = x[i].Count();
        x2[i] = x[i].Count();

        Sorting_array.Add(x[i], x1[i]);
        i++;
    } catch(Exception ex) {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Enter the string again");
    }

}

Array.Sort(x1);
Console.WriteLine("This is the array after sorting");
for (int j=0; j<x1.Length; j++)
{
    
    Console.Write(x[Array.IndexOf(x2, x1[x1.Length - j - 1])] +" ");
}

