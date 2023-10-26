using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int minRnd = 10, maxRnd = 99;
        int size = 30;
        int threshold = 50;
        int minRange = 40, maxRange = 70;

        int[] array = Enumerable.Range(1, size).Select(i => rnd.Next(10, 99)).ToArray();

        Console.WriteLine($"Array: {string.Join(" ", array)}\n");

        Console.WriteLine($"Even numbers: {string.Join(" ",
            array.Where(i => i % 2 == 0).ToArray())}\n");

        Console.WriteLine($"Odd numbers: {string.Join(" ",
            array.Where(i => i % 2 != 0).ToArray())}\n");

        Console.WriteLine($"Numbers greater then {threshold}: {string.Join(" ",
            array.Where(i => i > threshold).ToArray())}\n");

        Console.WriteLine($"Numbers in range {minRange} to {maxRange}: {string.Join(" ",
            array.Where(i => i > minRange && i < maxRange).ToArray())}\n");

        Console.WriteLine($"Numbers mult 7 by grows: {string.Join(" ",
            array.Where(i => i % 7 == 0).ToArray().OrderBy(i => i))}\n");

        Console.WriteLine($"Numbers mult 8 by descending: {string.Join(" ",
            array.Where(i => i % 8 == 0).ToArray().OrderByDescending(i => i))}\n");
    }
}
