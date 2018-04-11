using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    public class ConferenceRoomsManager
    {
        private readonly List<ConferenceRoom> rooms = new List<ConferenceRoom>();
        public List<ConferenceRoom> GetRooms()
        {
            if (rooms.Count ==0)
            {
                ReadRoomData();
            }
            return rooms;
        }

        private void ReadRoomData()
        {
            rooms.Add(new ConferenceRoom() { ID = 1, Reservations = new List<Reservation>() });
            rooms.Add(new ConferenceRoom() { ID = 2, Reservations = new List<Reservation>() });
            rooms.Add(new ConferenceRoom() { ID = 3, Reservations = new List<Reservation>() });

        }

        public void Add(ConferenceRoom room)
        {
            rooms.Add(room);
        }
        public void Remove (ConferenceRoom room)
        {
            rooms.Remove(room);
        }
        public void Book(ConferenceRoom room, DateTime from, DateTime to)
        {
            room.Reservations.Add(new Reservation() {From=from,To=to });

        }
        public bool IsTimeSlotAvailable(ConferenceRoom room, DateTime from, DateTime to)
        {
          var found =  room.Reservations.Find(r => r.From >= from && r.To <= to);
          return null == found;

        }

    }
    public class ConferenceRoom
    {
        public int ID { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
    public class Reservation
    {
        public ConferenceRoom Room { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Person { get; set; }
    }
}
