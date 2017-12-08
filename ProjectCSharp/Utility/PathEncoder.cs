using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectCSharp.Utility
{
    static class PathEncoder
    {
        static readonly string invalidChars = @"""\/?:<>*|";
        static readonly string escapeChar = "%";

        static readonly Regex escaper = new Regex(
            "[" + Regex.Escape(escapeChar + invalidChars) + "]",
            RegexOptions.Compiled);
        static readonly Regex unescaper = new Regex(
            Regex.Escape(escapeChar) + "([0-9A-Z]{4})",
            RegexOptions.Compiled);

        public static string NormalizePath(string path)
        {
            return Path.GetFullPath(path).Replace(@"\", @"\\");
        }

        public static string Escape(string path)
        {
            return escaper.Replace(path,
                m => escapeChar + ((short)(m.Value[0])).ToString("X4"));
        }

        public static string Unescape(string path)
        {
            return unescaper.Replace(path,
                m => ((char)Convert.ToInt16(m.Groups[1].Value, 16)).ToString());
        }
    }
}
