using System;
using FileSystemAlias = System.IO;

namespace Demos
	{
    
    class Samples
    {
        static void Main(string[] args)
        {
            //UsingWithAlias();
            //VariablesAndOperators();
            //TypeConversions();
            //IfStatement();
            //SwitchStatement();
            //  ctrl + K ctrl + C   (comment)
            //  ctrl + K ctrl + U   (uncomment)

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--- reverse for");
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("--while");
            int j = 0;
            while (j < 4)
            {
                Console.WriteLine(j);
                j++;
                
            }

            foreach (var item in "abcdef")
            {
                Console.WriteLine($"{item} is digit: {char.IsDigit(item)}, is letter: {char.IsLetter(item)}");
            }

            foreach (var param in args)
            {
                Console.WriteLine(param);
            }
                        


        }

        private static void SwitchStatement()
        {
            var currentDay = DateTime.Today.DayOfWeek;
            switch (currentDay)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Business day");
                    break;
            }
        }

        private static void IfStatement()
        {
            var amount = 100m;
            if (amount > 999)
            {
                Console.WriteLine("Requires approval");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("amount should be greater than 0");
            }
            else
            {
                Console.WriteLine("Accepted");
            }

            bool requiresApproval = false;
            // ? : operator
            requiresApproval = amount > 999 ? true : false;
            // full if version
            if (amount > 999)
            {
                requiresApproval = true;
            }
            else
            {
                requiresApproval = false;
            }
        }

        private static void VariablesAndOperators()
        {
            object o = new object();
            Console.WriteLine(o.GetHashCode());

            string message = "hello";
            //string wiht object GetHashCode member
            Console.WriteLine(message.GetHashCode());
            int x = 10;

            x += 10;
            x = x + 10;
            
            var dt = DateTime.Now.Date.Month;


        }

        private static void TypeConversions()
        {

            int i = 10;
            //implicit conversion
            long j = i;
            //explicit conversion
            int k = (int)j;

            decimal tax = 10 * 19 / 100;
            //cast operator ()
            tax = (decimal)10 * 19 / 100;
            //Convert class
            tax = Convert.ToDecimal(10 * 0.19);
            tax = Convert.ToDecimal(10 * 19 / 100);

            string amount = "200,50";
            decimal dAmount = decimal.Parse(amount);

            //System.Threading.Thread.CurrentThread.CurrentCulture
            string orderDate = "01/02/10";
            DateTime dOrderDate = DateTime.Parse(orderDate);
        }

        private static void UsingWithAlias()
        {
            FileSystemAlias.File.Create("log.txt");
        }
    }
	}