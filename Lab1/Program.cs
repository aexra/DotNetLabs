///
/// .NET Lab #1
/// Ver. 3 (19)
///

Console.WriteLine("Enter int array separated with spaces...");
Console.WriteLine(string.Join(' ', Core.Algorithms.Sortings.BubbleSort(Console.ReadLine()?.Split(' ').Select(int.Parse).ToList())));