# SimpleConsoleColor

![Nuget](https://img.shields.io/nuget/v/SimpleConsoleColor)

A simple library for setting console colors when writing. Usage:

```c#
using (SimpleConsoleColors.Red)
{
    Console.WriteLine("Red");

    using (SimpleConsoleColors.Blue)
    {
        Console.WriteLine("Blue");

        using (SimpleConsoleColors.Green)
        {
            Console.WriteLine("Green");
        }

        Console.WriteLine("Blue");
    }

    Console.WriteLine("Red");
}
```

Result:

![Result](https://i.imgur.com/sWyNUJc.png)
