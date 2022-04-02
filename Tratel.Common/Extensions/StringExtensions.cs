using System.Text;

namespace Tratel.Common.Extensions;

public static class StringExtensions
{
    public static string Formalize(this string text)
    {
        var parts = text.Trim().Split(' ');
        var lastIndex = parts.Length - 1;
        var beautifiedParts = new List<string>();
        var excludedChars = new List<char> { '!', '?', '*', '+', '$', '@', '%' };
        var index = 0;
        foreach (var part in parts)
        {
            var plainName = string.Join("", part.Where(f => !excludedChars.Contains(f)));
            if (string.IsNullOrWhiteSpace(part.Trim()))
            {
                continue;
            }
            if (index != lastIndex)
            {
                if (part.Length == 1 && char.IsPunctuation(part[0]))
                {
                    beautifiedParts[beautifiedParts.Count - 1] += part;
                    index++;
                    continue;
                }
                beautifiedParts.Add($"{plainName.Substring(0,1).ToUpper()}{plainName.Substring(1).ToLower()}");
                index++;
                continue;
            }
            beautifiedParts.Add(plainName.ToUpper());
            index++;
        }

        return string.Join(' ', beautifiedParts);
    }
}
