using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectCSharp.Utility
{
    class FileIO
    {
        public static void remove(string @fn)
        {
            if (!File.Exists(@fn)) return;
            File.Delete(fn);
        }

        public static string read(string @fn)
        {
            if (!File.Exists(@fn)) return null;
            return File.ReadAllText(fn);
        }

        public static void write(string @fn, string v)
        {
            File.WriteAllText(fn, v);
        }
    }
}
