using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dizi
        int[] arr = { 3, 1, 4, 1, 5 };
        Array.Sort(arr);
        Console.WriteLine("Dizi (sıralı): " + string.Join(", ", arr));

        // List
        var list = new List<string> { "C#", "ASP.NET", "EF Core" };
        list.Add("LINQ");
        list.Remove("ASP.NET");
        Console.WriteLine("Liste: " + string.Join(" | ", list));

        // Basit arama
        bool hasLinq = list.Contains("LINQ");
        Console.WriteLine($"LINQ var mı? {hasLinq}");
    }
}