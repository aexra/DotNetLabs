using Lab5.Extensions;
Console.WriteLine(string.Join(" ", Console.ReadLine().Split(" ").Ordered(s => s.Length)));