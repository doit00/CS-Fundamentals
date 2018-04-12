#define DIAG
using System;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //switch Debug to Release
#if DEBUG
            Console.WriteLine("debug is enabled");

#else
            Console.WriteLine("debug is not enabled");
#endif

#if DIAG
#warning DIAG is defined
            Console.WriteLine("diagnostic is enabled");
#endif

        }
    }
    class Data
    {
#pragma warning disable CS0649
        public string format;
    }
}
