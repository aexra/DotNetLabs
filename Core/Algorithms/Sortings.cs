namespace Core.Algorithms;

public class Sortings
{
    public static IList<T> BubbleSort<T>(IList<T> items) where T : IComparable<T>
    {
        bool sorted;

        do
        {
            sorted = true;
            for (var i = 0; i < items.Count() - 1; i++)
            {
                var compare = items[i].CompareTo(items[i + 1]);
                if (compare > 0)
                {
                    var tmp = items[i];
                    items[i] = items[i + 1];
                    items[i + 1] = tmp;
                    sorted = false;
                }
            }
        } while (!sorted);

        return items;
    }
    public static IList<T> BubbleSort<T>(IList<T> items, Comparer<T> comparer)
    {
        bool sorted;

        do
        {
            sorted = true;
            for (var i = 0; i < items.Count() - 1; i++)
            {
                var compare = comparer.Compare(items[i], items[i + 1]);
                if (compare > 0)
                {
                    var tmp = items[i];
                    items[i] = items[i + 1];
                    items[i + 1] = tmp;
                    sorted = false;
                }
            }
        } while (!sorted);

        return items;
    }
}
