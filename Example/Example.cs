using System;

class inches
{
    static void Main()
    {
        long inches;
        long miles;

        miles = 93000000;

        inches = miles * 5280 * 12;

        Console.WriteLine("Distance to the sun: " + inches + " inches.");
    }
}