using System.Text;

namespace Integration.Core.Shared;

internal static class StringHelper
{
    public static string AddSpaces(
        int length,
        int max,
        string value,
        StringBuilder sb,
        bool clear = true
    )
    {
        if (length < max)
        {
            var whitespacesRemaing = max - length;
            sb.Append(value);

            if (clear)
                value = "";

            sb.Append(value.PadRight(whitespacesRemaing));
        }
        else
        {
            sb.Append(value);
        }

        return sb.ToString();
    }
}
