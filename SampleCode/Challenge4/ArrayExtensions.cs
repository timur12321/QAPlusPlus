using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    static class ArrayExtensions
    {
        public static string[] Concatente(this string[] head, string[] tail)
        {
            string[] combined = new string[head.Length + tail.Length];
            head.CopyTo(combined, 0);
            tail.CopyTo(combined, head.Length);
            return combined;
        }

        public static string[] AddElement(this string[] head, string element)
        {
            string[] combined = new string[head.Length + 1];
            head.CopyTo(combined, 0);
            combined[combined.Length - 1] = element;
            return combined;
        }
    }
}
