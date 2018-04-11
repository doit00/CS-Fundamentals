using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfoLinq();
            ProcessQuery();
            SimpleNumbersLinq();

        }

        private static void SimpleNumbersLinq()
        {
            var AllNums = Enumerable.Range(1, 10);

            //Extension method Where:
            var qEven = AllNums.Where(n => n % 2 == 0);
            var qOdd = AllNums.Where(n => n % 2 == 1);

            //Extension method Sum
            //public static int Sum(this IEnumerable<int> source)
            var sumEven = qEven.Sum();
            var sumOdd = qOdd.Sum();

            Console.WriteLine($"Sum of odds:{sumEven} Sum of evens:{sumOdd}");
            //google: Linq 101 Samples
        }

        private static void ProcessQuery()
        {
            var procs = Process.GetProcesses();
            var chromeProcesses =
                procs
                .Where(p => p.ProcessName == "chrome")
                .Select(p => new { Id = p.Id, MainModuleName = p.MainModule.FileName })
                ;
            var q3 = procs.Where(isChrome);
            chromeProcesses.ToList()
                .ForEach(p =>
                Console.WriteLine($"{p.Id}:{p.MainModuleName}"));
        }

        static bool isChrome(Process p)
        {
            return p.ProcessName == "chrome";
        }

        private static void FileInfoLinq()
        {
            var basePath = @"..\..\";
            DirectoryInfo dir = new DirectoryInfo(basePath);

            FileInfo[] files = dir.GetFiles();

            ForEachDemo(files);

            var query1 = from f in files
                         where f.Extension == ".cs"
                         select f;

            var query2 = files.Where(f => f.Length > 1024).Select(f => f);
            query2.ToList().ForEach(f => Console.WriteLine(f.FullName));

            //                         Func<FileInfo, bool> predicate
            var query3 = files.Where(f => f.Extension == ".cs");
            var query4 = files.Where(f => f.Length > 1);
        }

        static bool isCsFile(FileInfo f)
        {
            return f.Extension == ".cs";
        }
        static bool isGt1KB(FileInfo f)
        {
            return f.Length > 1024;
        }


        private static void ForEachDemo(FileInfo[] files)
        {
            foreach (var f in files)
            {
                if (f.Extension == ".cs")
                {
                    Console.WriteLine(f.FullName);
                }

            }
        }
    }
}
