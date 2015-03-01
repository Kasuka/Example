using System;

class PromDemo
{
    static void Main()
    {
        byte b;

        b = 10;
        b = (byte)(b * b);

        Console.WriteLine("b: " + b);
    }
}