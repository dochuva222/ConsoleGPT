using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGPT.Services
{
    public static class CustomConsole
    {
        public static void Write(string text)
        {
            foreach (var symbol in text)
            {
                Console.Write(symbol);
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }

        public static void Write(int value)
        {
            Write(value.ToString());
        }

        public static void Write(float value)
        {
            Write(value.ToString());
        }

        public static void Write(char value)
        {
            Write(value.ToString());
        }

        public static void Write(double value)
        {
            Write(value.ToString());
        }
    }
}
