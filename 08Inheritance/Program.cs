using System;
using System.IO;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            //InheritedMembers();

            //SetOut (TextWriter -> Abstract class)
            Console.SetOut(new StreamWriter("CONSOLE.log"));
            Console.WriteLine("Hello");
            Console.Out.Flush();


        }

        private static void InheritedMembers()
        {
            BaseReservation r1 = new HotelReservation();
            r1.ID = 1;
            r1.Description = "Last Minute 2018";
            r1.Registered = DateTime.Today;

            HotelReservation r2 = new HotelReservation();
            r2.ID = 2;
            r2.Description = "Super Hotel";
            r2.Registered = DateTime.Today;
            r2.HotelName = "Super Hotel";

            FlightReservation r3 = new FlightReservation();
            r3.ID = 3;
            r3.Description = "Super Airlines";
            r3.Registered = DateTime.Today;
            r3.Source = "KTW";
            r3.Destination = "PGP";


            PrintReservation(r1);
            PrintReservation(r2);
            PrintReservation(r3);
        }

        private static void PrintReservation(BaseReservation r1)
        {

            Console.WriteLine("Reservation: -----------");
            Console.WriteLine(r1.ID);
            Console.WriteLine(r1.Description);
            r1.GetDetails();


        }
    }


    abstract class BaseReservation
    {
  
        public int ID;
        public string Description;
        public DateTime Registered { get; set; }
        public virtual void GetDetails()
        {
            Console.WriteLine($"id:{ID}, Desc{Description}");
        }
        public abstract void Confirm();
    }
    class HotelReservation : BaseReservation
    {
        public string HotelName;
        public DateTime From;
        public DateTime To;
        public bool OverbookingAllowed;

        public override void GetDetails()
        {
            Console.WriteLine($"id:{ID}, Desc{Description}, Hotel:{HotelName}");
        }
        public override void Confirm()
        {
            Console.WriteLine("Hotel Confirmation");
        }

    }
    class FlightReservation: BaseReservation
    {
        public string Source;
        public string Destination;
        public DateTime Departure;
        public DateTime Arrive;

        public override void Confirm()
        {
            Console.WriteLine("Agent confirmation");
        }

        public override void GetDetails()
        {
            Console.WriteLine($"id:{ID}, Desc{Description}, Source-Destination:{Source}-{Destination}");
        }
    }

 


}
