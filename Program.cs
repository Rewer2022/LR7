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
        }

        private static void WriteTextWithBorder(string text)
        {
            string a = "=";
            string b = "";
            for (int i = 0; i < text.Length + 2; i++)
            {
                a += "-";
                b += " ";
            }
            Console.WriteLine(a + "=");
            Console.WriteLine("|" + b + "|");
            Console.WriteLine("| " + text + " |");
            Console.WriteLine("|" + b + "|");
            Console.WriteLine(a + "=");
        }
    } 
}