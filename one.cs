using System;
using System.IO;
using static System.Text.Encoding;
using Microsoft.VisualBasic;
namespace ConsoleApp
{
    internal static class Program
    {
        private static void Main()
        {
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                for (var i = 0; i <= 1000; i++)
                {
                    Console.Write(Strings.ChrW(i));
                    if (i % 50 == 0)
                    { // break every 50 chars
                        Console.WriteLine();
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
