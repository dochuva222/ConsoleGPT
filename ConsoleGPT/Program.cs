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
            var gpt = new ClientGPT();
            while (true)
            {
                var question = Console.ReadLine();
                gpt.AskGPT(question);
            }
        }
    }
}
