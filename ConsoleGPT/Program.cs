using ConsoleGPT.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var gpt = new ClientGPT("отвечай на все последующие вопросы в стиле вселленной киберпанка");
            while (true)
            {
                Console.Write("message: ");
                var question = Console.ReadLine();
                gpt.Ask(question);
            }
        }
    }
}
