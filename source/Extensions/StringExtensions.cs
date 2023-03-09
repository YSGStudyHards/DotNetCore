using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace DotNetCore.Extensions;

public static partial class StringExtensions
{
    public static T Deserialize<T>(this string value) where T : class
    {
        return string.IsNullOrWhiteSpace(value)
            ? default
            : JsonSerializer.Deserialize<T>(value, new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString,
                PropertyNameCaseInsensitive = true
            });
    }

    public static string ExtractNumbers(this string value) => string.IsNullOrWhiteSpace(value) ? value : Regex.Replace(value, @"[^0-9]", string.Empty);

    public static string RemoveAccents(this string value) => string.IsNullOrWhiteSpace(value) ? value : Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(value));

    public static string RemoveDuplicateSpaces(this string value) => string.IsNullOrWhiteSpace(value) ? value : Regex.Replace(value, @"\s+", " ");

    public static string RemoveSpecialCharacters(this string value) => string.IsNullOrWhiteSpace(value) ? value : Regex.Replace(value, "[^0-9a-zA-Z ]+", string.Empty);

    public static string Sanitize(this string value) => string.IsNullOrWhiteSpace(value) ? value : value.RemoveSpecialCharacters().RemoveDuplicateSpaces().RemoveAccents();
}
