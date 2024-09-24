using Lab5.Classes.Containers;

namespace Lab5.Extensions;

internal static class StringArrayExtensions
{
    public static MyContainer<string> ToMyContainer(this string[] array)
    {
        return new MyContainer<string>(array);
    }
}
