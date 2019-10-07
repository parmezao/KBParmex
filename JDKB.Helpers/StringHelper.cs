using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace JDKB.Helpers
{
    public static class StringHelper
    {
        public static string[] KeyWordToArray(this string keyWord)
        {
            string[] palavras = keyWord
                .Replace(" ", ";")
                .Replace(",", ";")
                .Replace("_", ";")
                .Replace("-", ";")
                .Replace(".", ";")
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            return palavras;
        }

        public static string Wrap(this string value, int MaxSize, string completeWith = "...")
        {
            if (value.Length > MaxSize)
            {
                return value.Substring(0, MaxSize) + completeWith;
            }
            else
            {
                return value;
            }
        }

        public static string CaseInsenstiveReplace(this string originalString, string oldValue, string newValue, out bool IsMath)
        {
            Regex regEx = new Regex(oldValue, RegexOptions.IgnoreCase | RegexOptions.Multiline);

            IsMath = regEx.IsMatch(originalString);

            return regEx.Replace(originalString, newValue);
        }

        public static string RemoveAccents(this string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();

            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }

            return sbReturn.ToString();
        }

        public static string AddAccents(this string Value)
        {
            Value = Value.Replace("a", "[aáâàäã]");
            Value = Value.Replace("A", "[AÁÂÀÄÃ]");

            Value = Value.Replace("e", "[eéêèë]");
            Value = Value.Replace("E", "[EÉÊÈË]");

            Value = Value.Replace("i", "[iíîìï]");
            Value = Value.Replace("I", "[IÍÎÌÏ]");

            Value = Value.Replace("o", "[oóôòöõ]");
            Value = Value.Replace("O", "[OÓÔÒÖÕ]");

            Value = Value.Replace("u", "[uúûùü]");
            Value = Value.Replace("U", "[UÚÛÙÜ]");

            Value = Value.Replace("c", "[cç]");
            Value = Value.Replace("C", "[CÇ]");

            Value = Value.Replace("n", "[nñ]");
            Value = Value.Replace("N", "[NÑ]");

            return Value;
        }

        public static string SplitText(this string html, Func<string, string> htmlResult, char Delimiter = ',', string Separator = " · ‎")
        {
            string newHtml = "";
            foreach (var item in html.Split(Delimiter))
            {
                newHtml += htmlResult(item) + Separator;
            }

            return newHtml.Substring(0, newHtml.Length - Separator.Length);
        }

        public static string Encrypt(this string senha)
        {
            var salt = "|DD6F458B13274FDC8782F3FABC749E396C4907F4A6F446DA96A69F9D20FB44DA";

            var arrayBytes = Encoding.UTF8.GetBytes(senha + salt);

            byte[] hashBytes;
            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arrayBytes);
            }

            return Convert.ToBase64String(hashBytes);
        }

        public static string DecimalDateToString(this decimal date)
        {
            return $"{date.ToString().Substring(6, 2)}/" +
                $"{date.ToString().Substring(4, 2)}/" +
                $"{date.ToString().Substring(0, 4)}";
        }

        public static string ToDebugString<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
        {
            return "{" + string.Join(",", dictionary.Select(kv => kv.Key + ":" + "\"" + kv.Value + "\"").ToArray()) + "}";
        }
    }
}
