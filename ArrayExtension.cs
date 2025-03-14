namespace CLIArgsHandler;

public static class ArrayExtension
{
    // https://stackoverflow.com/a/457501/21231652
    public static T[] RemoveAt<T>(this T[] source, int index, int skip)
    {
        var dest = new T[source.Length - skip];
        if (index > 0)
            Array.Copy(source, 0, dest, 0, index);

        if (index < source.Length - skip)
            Array.Copy(source, index + skip, dest, index, source.Length - index - skip);

        return dest;
    }
}