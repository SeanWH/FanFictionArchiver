// FILE: StringExtensions.cs
// PROJECT: SWH.Extensions
// SOLUTION: FanFictionArchiver
// -------------------------------------------
// AUTHOR: Sean Hennessey
// DATE CREATED: 2021-05-17
// DATE MODIFIED: 2021-05-17

namespace SWH.Extensions.Types
{
    using System.IO;
    using System.Linq;
    using System.Text;

    public static class StringExtensions
    {
        public static int StringHash(this string val)
        {
            long total = 0;
            char[] chars = val.ToCharArray();

            foreach (char c in chars)
            {
                total += 11 * total + c;
            }

            total %= 49;

            total = total < 0 ? total + 49 : total;

            return (int)total;
        }

        public static string StripPunctuation(this string s)
        {
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                if (!char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        public static bool IsLocalPath(this string path) => File.Exists(path);

        public static bool IsInvalidPath(this string path) => ContainsInvalidPathCharacters(path);

        /// <summary>Determines if the path contains invalid characters.</summary>
        /// <remarks>
        ///     This method is intended to prevent ArgumentException's from being thrown when creating a new FileInfo on a
        ///     file path with invalid characters.
        /// </remarks>
        /// <param name="filePath">File path.</param>
        /// <returns>True if file path contains invalid characters.</returns>
        private static bool ContainsInvalidPathCharacters(string filePath)
        {
            return filePath.Any(c => c == '\"' || c == '<' || c == '>' || c == '|' || c == '*' || c == '?' || c < 32);
        }

        public static bool IsNullOrWhitespace(this string[] strings)
        {
            var check = false;

            foreach (string str in strings)
            {
                check |= string.IsNullOrWhiteSpace(str);
            }

            return check;
        }

        public static string Prefix(this string target, string prefix) => $"{prefix}{target}";

        public static string Affix(this string target, string affix) => $"{target}{affix}";
    }
}