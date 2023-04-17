using System;

class Program
{
    static double Calculate(double x)
    {
        int a = new Random().Next(-50, 50);
        if (x < 0)
        {
            return x + Math.Pow(Math.Sin(1 / x - a) + 4, 2);
        }
        else if (a * a > x * x) 
        {
            return a * x / Math.Sqrt(Math.Pow(a, 2) - Math.Pow(x, 2));
        }
        else
        {
            throw new ArgumentException("Invalid input value: division by zero");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Calculate(-1) = " + Calculate(-1)); 
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
