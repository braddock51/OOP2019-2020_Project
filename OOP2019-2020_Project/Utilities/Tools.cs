using System;

namespace Utilities
{
    public static class Tools
    {
        public static void ColorfulWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();

        }

        public static void AuthorInfo()
        {
            ColorfulWriteLine("Author: Maksymilian Wrobel\n" +
                              "Created for project 2019-2020 OOP Class in UWM WMII\n" +
                              "All rights reserved\n", ConsoleColor.Green);
        }
    }
}
