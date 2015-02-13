using System;

class Example3
{
    static void Main()
    {
        int iVar;
        double dVar;

        iVar = 100;
        dVar = 100.0;

        Console.WriteLine("Original value of iVar: " + iVar);
        Console.WriteLine("Original value of dVar: " + dVar);

        Console.WriteLine();

        iVar = iVar / 3;
        dVar = dVar / 3.0;

        Console.WriteLine("iVar after division: " + iVar);
        Console.WriteLine("dVar after division: " + dVar);
    }
}