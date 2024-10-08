using System;

static class NumericFn
{
    // Згенерувати масив випадкових чисел від 0 до 1, відсортувати і знайти min/max
    public static void GenerateAndProcessArray()
    {
        Random rand = new Random();
        double[] array = new double[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.NextDouble();
        }

        Array.Sort(array);
        double min = array[0];
        double max = array[array.Length - 1];

        Console.WriteLine("Масив:");
        foreach (double num in array)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine($"Min: {min}, Max: {max}");
    }

    // Лінійний пошук мінімального і максимального елементів
    public static void LinearSearch(int[] array)
    {
        int min = array[0];
        int max = array[0];

        foreach (int num in array)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        Console.WriteLine($"Min: {min}, Max: {max}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Тестування масиву з випадковими числами
        NumericFn.GenerateAndProcessArray();

        // Тестування лінійного пошуку
        int[] array = { 4, 5, 2, 3, 8, 7, 6, 1 };
        NumericFn.LinearSearch(array);

        Console.ReadKey();
    }
}

