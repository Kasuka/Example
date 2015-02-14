using System;

class IfDemo
{
    static void Main()
    {
        int a, b, c;

        a = 2;
        b = 3;

        if (a < b)
        {
            Console.WriteLine(" a is less than b.");
        }

        if (a == b)
        {
            Console.WriteLine("You won't see this.");
        }

        Console.WriteLine();

        c = a - b;

        Console.WriteLine("c contains -1.");

        if (c >= 0)
            Console.WriteLine("c is non-negative.");
        if (c < 0)
            Console.WriteLine("c is negative.");

        Console.WriteLine();

        c = b - a;
        Console.WriteLine("c contains 1.");
        if (c >= 0)
            Console.WriteLine("c is non-negative.");
        if (c < 0)
            Console.WriteLine("c is negative.");
    }
}
