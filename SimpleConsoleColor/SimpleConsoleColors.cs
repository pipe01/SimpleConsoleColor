using System;
using System.Collections.Generic;

namespace SimpleConsoleColor
{
    public class ColorPopper : IDisposable
    {
        internal ColorPopper() { }

        public void Dispose()
        {
            if (SimpleConsoleColors.ColorStack.Count > 0)
                Console.ForegroundColor = SimpleConsoleColors.ColorStack.Pop();
        }
    }

    public static class SimpleConsoleColors
    {
        internal static readonly Stack<ConsoleColor> ColorStack = new Stack<ConsoleColor>();
        private static readonly ColorPopper PopperInstance = new ColorPopper();

        private static ColorPopper Push(ConsoleColor clr)
        {
            ColorStack.Push(Console.ForegroundColor);
            Console.ForegroundColor = clr;
            return PopperInstance;
        }

        public static ColorPopper Black => Push(ConsoleColor.Black);
        public static ColorPopper Blue => Push(ConsoleColor.Blue);
        public static ColorPopper Cyan => Push(ConsoleColor.Cyan);
        public static ColorPopper DarkBlue => Push(ConsoleColor.DarkBlue);
        public static ColorPopper DarkCyan => Push(ConsoleColor.DarkCyan);
        public static ColorPopper DarkGray => Push(ConsoleColor.DarkGray);
        public static ColorPopper DarkGreen => Push(ConsoleColor.DarkGreen);
        public static ColorPopper DarkMagenta => Push(ConsoleColor.DarkMagenta);
        public static ColorPopper DarkRed => Push(ConsoleColor.DarkRed);
        public static ColorPopper DarkYellow => Push(ConsoleColor.DarkYellow);
        public static ColorPopper Gray => Push(ConsoleColor.Gray);
        public static ColorPopper Green => Push(ConsoleColor.Green);
        public static ColorPopper Magenta => Push(ConsoleColor.Magenta);
        public static ColorPopper Red => Push(ConsoleColor.Red);
        public static ColorPopper White => Push(ConsoleColor.White);
        public static ColorPopper Yellow => Push(ConsoleColor.Yellow);
    }
}
