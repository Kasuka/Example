using System;

class ImplicitlyTypedVar
{
    static void Main()
    {
        var s1 = 4.0;
        var s2 = 5.0;

        var hypot = Math.Sqrt((s1 * s1) + (s2 * s2));

        Console.Write("Hypotenuse of triangle with sides " + s1 + " by " + s2 + " is ");
        Console.WriteLine("{0:#.###}", hypot);
    }
}