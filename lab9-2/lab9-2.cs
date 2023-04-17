using System;

class Program
{
    static void Main(string[] args)
    {
        double[] arr = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Массив до изменения:");
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        EnterPartOfArray(arr, 2, 7);

        Console.WriteLine("Массив после ввода:");
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        FillPartOfArrayWithRandom(arr, 1, 8);

        Console.WriteLine("Массив после заполнения случайными числами:");
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    static void EnterPartOfArray(double[] arr, int k1, int k2)
    {
        for (int i = k1; i <= k2; i++)
        {
            Console.Write($"Введите элемент {i} массива: ");
            arr[i] = double.Parse(Console.ReadLine());
        }
    }

    static void FillPartOfArrayWithRandom(double[] arr, int k1, int k2)
    {
        Random rand = new Random();
        for (int i = k1; i <= k2; i++)
        {
            arr[i] = rand.NextDouble();
        }
    }
}
