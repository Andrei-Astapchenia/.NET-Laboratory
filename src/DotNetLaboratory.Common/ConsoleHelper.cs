using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetLaboratory.Common
{
    public static class ConsoleHelper //Утилита для вывода
    {
        public static void Header(string title)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($" {title}");
            Console.WriteLine(new string('-', 60));
            Console.ResetColor(); 
        }
        public static void SubHeader(string subtitle)
        {
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine($"--- {subtitle} ---");
            Console.ResetColor();
        }
        public static void Result(string label, object? value) 
        {
            Console.Write($"{label}: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void Info(string message)
        {
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Separator()
        {
            Console.WriteLine(new string('-', 60));
        }
        public static void WaitForEnter()
        {
            Console.WriteLine();
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.Write("Нажмите Enter, чтобы продолжить...");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
