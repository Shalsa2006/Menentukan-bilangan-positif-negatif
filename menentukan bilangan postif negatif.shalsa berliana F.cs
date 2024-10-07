using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input any number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("This number negative");
        }
        else if (num > 0)
        {
            Console.WriteLine("This number positive");
        }
        else
        {
            Console.WriteLine("This number is zero");
        }
        }
    }