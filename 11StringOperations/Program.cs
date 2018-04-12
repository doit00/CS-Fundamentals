using System;
using System.Text;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            StringFormats();

            GetAsciCode();
        }

        private static void StringFormats()
        {
            string message1 = "hello";
            // escape char \t -tab \n -new line
            string message2 = "id\tdate\tname\n01\t03/02\tJohn\n02\t04/02\tJill";
            // path separator escaping (\)
            string path1 = "C:\\Program Files\\Common Files\\microsoft shared";
            // verbatim string @ 
            string path2 = @"C:\Program Files\Common Files\microsoft shared";
            //string.Format with parameter substitution
            string message3 = string.Format("Computer:{0} Processors:{1}",
                                Environment.MachineName, Environment.ProcessorCount);
            //parameter formats
            string message4 = string.Format("{0:f2}", 0.1234);
            //field length
            string message5 = string.Format("{0,2}\n{1,2}", 9, 10);

            //string interpolation
            string message6 = $"OS Version: {Environment.OSVersion.VersionString}";

            Console.WriteLine(message1);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
            Console.WriteLine(message4);
            Console.WriteLine(message5);
            Console.WriteLine(message6);
        }

        private static void GetAsciCode()
        {
            var bts = Encoding.ASCII.GetBytes("abcABC");
            foreach (var b in bts)
            {
                Console.WriteLine(b);
            }
        }
    }
}
