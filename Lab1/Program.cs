///
/// .NET Lab #1
/// Ver. 3 (19)
///

Console.WriteLine("Enter int array separated with spaces...");
var items = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();

Console.WriteLine($"""
    BubbleSort: {Core.Misc.TimeUtils.Measure(() => Core.Algorithms.Sortings.BubbleSort(new List<int>(items)))}
    QuickSort: {Core.Misc.TimeUtils.Measure(() => Core.Algorithms.Sortings.QuickSort(new List<int>(items)))}
    InsertionsSort: {Core.Misc.TimeUtils.Measure(() => Core.Algorithms.Sortings.InsertionSort(new List<int>(items)))}
    """);