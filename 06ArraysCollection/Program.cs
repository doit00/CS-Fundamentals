using System;
using System.Collections.Generic;
using System.Net;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays();
            GenericLists();
            GenericDictionaries();

            Queues();
            Stacks();

            //Generic Sort
            //Array.Sort<int>()
            //Untyped Sort
            //Array.Sort(array)

           
            

        }

        private static void Stacks()
        {
            Stack<string> commands = new Stack<string>();
            commands.Push("draw");
            commands.Push("resize");
            commands.Push("fill");

            while (commands.Count > 0)
            {
                var c = commands.Pop();
                Console.WriteLine(c);

            }
        }

        private static void Queues()
        {
            Queue<string> Queries = new Queue<string>();
            Queries.Enqueue("Select * From Orders");
            Queries.Enqueue("Select * From Customers");

            var CurrentQuery = Queries.Dequeue();
            Console.WriteLine(CurrentQuery);
        }

        private static void GenericDictionaries()
        {
            SortedDictionary<int, string> coll = new SortedDictionary<int, string>();
            coll.Add(10, "agadfa10");
            coll.Add(2, "dasfa2");
            coll.Add(6, "adsfa6");
            //coll.Add(2, "abc");

            foreach (var k in coll.Keys)
            {
                Console.WriteLine($"key: {k} value:{coll[k]}");

            }


            SortedDictionary<string, string> machines = new SortedDictionary<string, string>();
            machines.Add("win10", "192.168.1.10");
            machines.Add("win8", "192.168.1.11");
            machines.Add("win srv 16", "192.168.1.12");

            var ipAdd = machines["win10"];

            SortedDictionary<string, IPAddress> machines2 = new SortedDictionary<string, IPAddress>();
            machines2.Add("win10", IPAddress.Parse("192.168.1.12"));
        }

        private static void GenericLists()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(9);

            List<string> days = new List<string>() { "Pn", "Wt" };
            days.Add("Śr");
        }

        private static void Arrays()
        {
            int[] numbers = new int[4];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 4;
            numbers[3] = 8;

            //Array initializer
            int[] numbers2 = { 1, 2, 4, 8, 16 };


            foreach (var n in numbers2)
            {
                Console.WriteLine(n);
            }



            //multidimensional arrays
            int[,] points = { { 1, 0 }, { 2, 1 } };
            int[,] points2 = new int[2, 2];
            points2[0, 0] = 1;
            points2[0, 1] = 0;

            var tableLen = numbers.Length;
            var dim1Len = points.GetLength(0);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            DateTime[] dates = {
                DateTime.Today
                ,new DateTime(2018,1,1)
                ,new DateTime(2013,8,19)
            };

            foreach (var d in dates)
            {
                Console.WriteLine(d);
            }


            Array.Sort(dates);

            foreach (var d in dates)
            {
                Console.WriteLine(d);
            }

            Array.Sort(numbers);
        }
    }
}
