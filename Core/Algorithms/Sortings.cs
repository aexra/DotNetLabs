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

    public static IList<T> QuickSort<T>(IList<T> items) where T : IComparable<T>
    {
        QuickSort(items, 0, items.Count - 1);
        return items;
    }
    private static void QuickSort<T>(IList<T> items, int low, int high) where T : IComparable<T>
    {
        if (low < high)
        {
            int pivotIndex = Partition(items, low, high);
            QuickSort(items, low, pivotIndex - 1);
            QuickSort(items, pivotIndex + 1, high);
        }
    }
    private static int Partition<T>(IList<T> list, int low, int high) where T : IComparable<T>
    {
        T pivot = list[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (list[j].CompareTo(pivot) < 0)
            {
                i++;
                Swap(list, i, j);
            }
        }

        Swap(list, i + 1, high);
        return i + 1;
    }
    private static void Swap<T>(IList<T> list, int i, int j)
    {
        T temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }

    public static void InsertionSort<T>(IList<T> list) where T : IComparable<T>
    {
        for (int i = 1; i < list.Count; i++)
        {
            T key = list[i];
            int j = i - 1;

            while (j >= 0 && list[j].CompareTo(key) > 0)
            {
                list[j + 1] = list[j];
                j--;
            }
            list[j + 1] = key;
        }
    }
}
