using Lab5.Extensions;
Console.WriteLine(string.Join(" ", Console.ReadLine().Split(" ").ToMyContainer().Ordered(s => s.Length)));
