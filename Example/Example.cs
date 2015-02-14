using System;

class ProdSum
{
    static void Main()
    {
        int prod;
        int sum;
        int i;

        sum = 0;
        prod = 1;

        for (i = 1; i <= 10; i++)
        {
            sum += i;
            prod *= i;
        }

        Console.WriteLine("Sum is " + sum);
        Console.WriteLine("Product is " + prod);
    }
}