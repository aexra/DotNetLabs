namespace Lab5.Extensions;
internal static class IEnumerableExtensions
{
    public static IEnumerable<T> Ordered<T, K>(this IEnumerable<T> container, Func<T, K> keySelector) where K : IComparable<K>
    {
        var sortingArray = container.ToArray();

        var sorted = false;
        while (!sorted)
        {
            sorted = true;
            for (var i = 0; i < sortingArray.Count() - 1; i++)
            {
                var f = sortingArray.ElementAt(i);
                var s = sortingArray.ElementAt(i + 1);
                if (keySelector(f).CompareTo(keySelector(s)) > 0)
                {
                    sortingArray[i] = s;
                    sortingArray[i + 1] = f;
                    sorted = false;
                }
            }
        }

        foreach (var v in sortingArray)
        {
            yield return v;
        }
    }

    public static IEnumerable<KeyValuePair<T, uint>> CountItems<T>(this IEnumerable<T> container)
    {
        var dict = new Dictionary<T, uint>();
        foreach (var item in container)
        {
            if (dict.ContainsKey(item))
            {
                dict[item]++;
                continue;
            }

            dict.Add(item, 1);
        }

        foreach (var kv in dict)
        {
            yield return kv;
        }
    }
}
