using Integration.Shared.Exceptions;

namespace Integration.Shared.Extensions;

public static class ObjectExtensions
{
    public static T ThrowIfNull<T>(this T obj, string message)
    {
        if (obj is null) throw new NotFoundException(message);
        return obj;
    }
}
