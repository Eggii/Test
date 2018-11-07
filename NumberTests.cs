using System;
using System.Collections.Generic;
namespace UniqeNumbers {

public static class NumberTests
{
    public static bool HasDuplicate<T>(
        this IEnumerable<T> source,
        out T firstDuplicate)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        var checkBuffer = new HashSet<T>();
        foreach (var t in source)
        {
            if (checkBuffer.Add(t))
            {
                continue;
            }

            firstDuplicate = t;
            return true;
        }

        firstDuplicate = default(T);
        return false;
    }
}
}