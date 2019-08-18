using System;
using System.Collections.Generic;
using SysConsoleColor = System.ConsoleColor;

namespace SimpleConsoleColor
{
    public static class SimpleConsoleColor
    {
        public class ColorPopper : IDisposable
        {
            internal ColorPopper() { }

            public void Dispose()
            {
                if (ColorStack.Count > 0)
                    Console.ForegroundColor = ColorStack.Pop();
            }
        }

        private static readonly Stack<SysConsoleColor> ColorStack = new Stack<SysConsoleColor>();
        private static readonly ColorPopper PopperInstance = new ColorPopper();

        private static ColorPopper Push(SysConsoleColor clr)
        {
            ColorStack.Push(Console.ForegroundColor);
            Console.ForegroundColor = clr;
            return PopperInstance;
        }

        public static ColorPopper Black => Push(SysConsoleColor.Black);
        public static ColorPopper Blue => Push(SysConsoleColor.Blue);
        public static ColorPopper Cyan => Push(SysConsoleColor.Cyan);
        public static ColorPopper DarkBlue => Push(SysConsoleColor.DarkBlue);
        public static ColorPopper DarkCyan => Push(SysConsoleColor.DarkCyan);
        public static ColorPopper DarkGray => Push(SysConsoleColor.DarkGray);
        public static ColorPopper DarkGreen => Push(SysConsoleColor.DarkGreen);
        public static ColorPopper DarkMagenta => Push(SysConsoleColor.DarkMagenta);
        public static ColorPopper DarkRed => Push(SysConsoleColor.DarkRed);
        public static ColorPopper DarkYellow => Push(SysConsoleColor.DarkYellow);
        public static ColorPopper Gray => Push(SysConsoleColor.Gray);
        public static ColorPopper Green => Push(SysConsoleColor.Green);
        public static ColorPopper Magenta => Push(SysConsoleColor.Magenta);
        public static ColorPopper Red => Push(SysConsoleColor.Red);
        public static ColorPopper White => Push(SysConsoleColor.White);
        public static ColorPopper Yellow => Push(SysConsoleColor.Yellow);
    }
}
