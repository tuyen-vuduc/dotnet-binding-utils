using System.Linq;

namespace Gradle.Binderator;

static class StringExtensions
{
    public static string ToCSharpName(this string x)
    {
        var varName = x.Substring(0, 1).ToUpper() + x.Substring(1);

        if (varName.Contains("-"))
        {
            varName = string.Join(
                string.Empty,
                varName.Split('-').Select(ToCSharpName)
            );
        }

        return varName;
    }
}
