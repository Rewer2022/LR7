using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        public static void Main()
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
            WriteTextWithBorder("I'm changed that!!!");
        }

        private static void WriteTextWithBorder(string text)
        {
            string a = "=";
            for (int i = 0; i < text.Length + 2; i++)
            {
                a += ("-");
            }
            Console.WriteLine(a + "=");
            Console.WriteLine("| " + text + " |");
            Console.WriteLine(a + "=");
        }
    } 
}