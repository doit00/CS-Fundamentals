using System;
using System.IO;

namespace Demos
{

    class Client
    {
       public static void DateOps()
        {
            Program.GetDaysToDate(DateTime.Today);
        }

        public void GetDate()
        {
        }
    }

   public delegate void LogMethod(string messageToLog);
   public class Program
    {
        static void Main(string[] args)
        {
            // ctrl+R ctr+M (Refactor Extract Method)
            //DateOperations();
            //StaticInstanceMethods();
            //ParametersDemo();
            //RefOutParams();

            //Action<string> log2 = LogToFile;
            //Func

            LogMethod log = LogToFile;
                     log += LogToConsole;
                     log += delegate (string m) {
                                Console.WriteLine("{0}:{1}",DateTime.Now,m);
                            };
                    log += (m) => {
                        Console.WriteLine("{0}:{1}", DateTime.Now, m);
                    };
            log("message");
            log("message");
            log("message");
            log("message");

            int count = 25;
            int sum = 428;
            //Full method
            double average =Avg(count,sum);
            //Anonymous method    --     delegate (params)       {body}
            Func<int, int, double> avg = delegate (int c, int s) { return (double)s / c; };
            //Lambda expression   --    (params) => expression/body
            Func<int, int, double> avg2 = (c, s) => (double)s / c;
            //Func<int, int, double> -- built-in
            //delegate double AvgDelegate(int count, int sum);  user defined
            average = avg2(count, sum);
        }
        private static double Avg(int count, int sum)
        {
            return (double)sum / count;
        }
        private static void LogToFile(string message)
        {
            File.AppendAllText("log.txt", message);
        }
        private static void LogToConsole(string message)
        {
            Console.WriteLine(message);
        }
        private static void RefOutParams()
        {
            int x = 10;
            PrintX(ref x);
            Console.WriteLine(x);

            x = -1;
            int y;
            bool isEven = IsEven(x, out y);
            Console.WriteLine("{0} r:{1}", isEven, y);

            //exception
            //int z = int.Parse("____aada__1234");

            int w;
            bool success = int.TryParse("12321", out w);
        }
        private static bool IsEven(int x, out int remainder)
        {
            int r = x % 2;
            remainder = r;
            return (r == 0);
        }

     

        private static void PrintX(ref int x)
        {
            x = 20;
            Console.WriteLine(x);
        }

        private static void StaticInstanceMethods()
        {
            //static metod
            Client.DateOps();

            //new Client instance (object)
            Client cli = new Client();
            //instance method
            cli.GetDate();

            var l1 = "".Length;
            var l2 = "abc".Length;
            var l3 = "a;ldkfja;lkfjq-03459u-qr".Length;

            String.IsNullOrEmpty("");
            String.IsNullOrEmpty("abc");

            Console.WriteLine();
            //Math.Sin();
        }

        private static void ParametersDemo()
        {

            GetOneShortDate();
            GetOneShortDate(-1);
            //GetDaysToDate();


            int quantity = 10;
            decimal unitPrice = 20.0m;
            int bonusPct = 10;
            //optional bonusPct 
            decimal total = GetTotal(quantity, unitPrice, bonusPct);
            //positional arguments
            decimal total2 = GetTotal(quantity, unitPrice);
            decimal total3 = GetTotal(quantity, unitPrice, priceFactor: 2);
            //named arguments
            decimal total4 = GetTotal(priceFactor: 3, unitPrice: 10m, quantity: 2);
        }

        private static decimal GetTotal(int quantity, decimal unitPrice, int bonusPct=0, int priceFactor = 1)
        {
            return unitPrice * quantity;
        }

        private static void DateOperations()
        {
            string date = GetShortDate();
            Console.WriteLine(date);
            string yesterday = GetShortDate(DateTime.Today.AddDays(-1));
            Console.WriteLine(yesterday);

            DayOfWeek day = GetDayofWeekFromDate(DateTime.Today);
            DayOfWeek dayBefore = GetDayofWeekFromDate(DateTime.Today.AddDays(-1));

            int days = GetDaysToDate(new DateTime(2014, 08, 19));
            Console.WriteLine(days);
        }

        public static int GetDaysToDate(DateTime date)
        {
            return (int) DateTime.Today.Subtract(date).TotalDays;
        }

        private static DayOfWeek GetDayofWeekFromDate(DateTime date)
        {
            return date.DayOfWeek;
        }

        static string GetShortDate()
        {
            return DateTime.Today.ToShortDateString();
        }
        static string GetShortDate(DateTime date)
        {
            return date.ToShortDateString();
        }
        static string GetOneShortDate(int daysBefore =0)
        {
            return DateTime.Today.AddDays(daysBefore).ToShortDateString();
        }
    }
}
