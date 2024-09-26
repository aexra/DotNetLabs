///
/// .NET Lab #5
/// Var. 3 (19)
///

using Lab5.Extensions;

/// MAIN

//Console.WriteLine(string.Join(" ", Console.ReadLine().Split(" ").ToMyContainer().Ordered(s => s.Length)));

/// EXTRA

var input = "dolgov pager ligma dolgov pager ligma pager ballz pager".Split(" ").ToMyContainer();

var dict = new Dictionary<string, uint>();
foreach (var item in input)
{
    if (dict.ContainsKey(item))
    {
        dict[item]++;
        continue;
    }

    dict.Add(item, 1);
}

Console.WriteLine("=======1=======\n");
Console.WriteLine(string.Join("\n", from kv in dict orderby kv.Value descending select $"{kv.Key} -> {kv.Value}"));

Console.WriteLine("\n\n=======2=======\n");
Console.WriteLine(string.Join("\n", from kv in input.CountItems() orderby kv.Value descending select $"{kv.Key} -> {kv.Value}"));
