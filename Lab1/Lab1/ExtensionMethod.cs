using System;

namespace Lab1
{
    public static class ExtensionMethod
    {
        public static int CountWord(this string s)
        {
            return s.Split(new[] {' ', '.', '?', '!'},
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}