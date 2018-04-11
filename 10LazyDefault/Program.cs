using System;
using System.IO;

namespace AdditionalTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            LazyInitialization();
            DefaultOperator();

        }

        private static void DefaultOperator()
        {
            int x = default(int);
            DateTime date = default(DateTime);
            string message = default(string);
            bool flag = default(bool);
            char character = default(char);

            var functionDelegate = default(Action<int, long, string>);
            functionDelegate  = (i, j, k) => Console.WriteLine($"{i}{j}{k}");
            var df = default(DataFile);

        }

        private static void LazyInitialization()
        {
            DataFile f = new DataFile() { FilePath = @"DataFile.txt" };
            Console.WriteLine(f.Name);
            //f.Content.IsValueCreated = false
            var lines = f.Content.Value;
            //f.Content.IsValueCreated = true
        }
    }

    class DataFile
    {
        public string Name => Path.GetFileName(FilePath);
        public string FilePath { get; set; }
        public Lazy<string[]> Content{
            get{
                return new Lazy<string[]>(GetFileContent);
            }
        }
        private string[] GetFileContent()
        {
            return File.ReadAllLines(FilePath);
        }
    }

    

}
