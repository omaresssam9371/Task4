using System.Reflection;
using System;

    class Program
    {

    static void Main(string[] args)

    {
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fact(x));
    }

    public static long Fact(int x)
        {
        if (x == 0) {
            return 1;
        }
            else
            {
                return (x * Fact(x - 1));
            }
        }


    }
