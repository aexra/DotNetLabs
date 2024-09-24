using System.Collections;

namespace Lab5.Classes.Containers;
internal class MyContainer<T> : IEnumerable<T>
{
    private IList<T> _container;

    public MyContainer()
    {
        _container = new List<T>();
    }

    public MyContainer(params T[] array)
    {
        _container = new List<T>(array);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var element in _container)
        {
            yield return element;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
