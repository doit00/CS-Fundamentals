using System;
using ToolsLibrary;

namespace _01LibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context();
            Console.WriteLine($"{ctx.User}, {ctx.Computer}, {ctx.Today:d}");
        }
    }
}
