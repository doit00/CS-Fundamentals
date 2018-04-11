using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Demos.Tests
{
    [TestClass()]
    public class ConferenceRoomsManagerTests
    {
        ConferenceRoomsManager manager = null;
        ConferenceRoom defaultRoom = null;

        [TestInitialize()]
        public  void Init()
        {
            manager = new ConferenceRoomsManager();
            defaultRoom = manager.GetRooms()[0];
            var from = new DateTime(2018, 06, 01, 11, 00, 00);
            var to = new DateTime(2018, 06, 01, 11, 30, 00);
            var newReservation = new Reservation() { From = from, To = to };
            defaultRoom.Reservations.Add(newReservation);


        }
        [TestCleanup()]
        public void Cleanup()
        {
            manager = null;
            defaultRoom = null;
        }

        [TestMethod()]
        public void GetRoomsTest()
        {
            //Arrange
            int minRoomCount = 1;
            //Act
            var rooms = manager.GetRooms();
            //Assert
            Assert.IsTrue(rooms.Count >= minRoomCount);
        }

        [TestMethod()]
        public void AddTest()
        {
            var roomsCount = manager.GetRooms().Count;
            var expectedRoomsCount = roomsCount + 1;

            manager.Add(new ConferenceRoom() { ID = 4 });
            roomsCount = manager.GetRooms().Count;

            Assert.AreEqual<int>(expectedRoomsCount, roomsCount);

        }

        [TestMethod()]
        public void RemoveTest()
        {
            var roomsCount = manager.GetRooms().Count;
            var expectedRoomsCount = roomsCount - 1;
            var roomToRemove = manager.GetRooms()[1];

            manager.Remove(roomToRemove);
            roomsCount = manager.GetRooms().Count;

            Assert.AreEqual<int>(expectedRoomsCount, roomsCount);

        }

        [TestMethod()]
        public void BookTest()
        {
            var from = new DateTime(2018, 06, 03, 10, 00, 00);
            var to = new DateTime(2018, 06, 03, 12, 00, 00);
            var reservationsCount = defaultRoom.Reservations.Count;
            var expected = reservationsCount + 1;

            manager.Book(defaultRoom, from, to);
            reservationsCount = defaultRoom.Reservations.Count;

            Assert.AreEqual<int>(expected,reservationsCount);
        }

        [TestMethod()]
        public void IsTimeSlotAvailableTest()
        {
            var r = defaultRoom.Reservations;
            var from = new DateTime(2018, 06, 02, 10, 00, 00);
            var to = new DateTime(2018, 06, 02, 12, 00, 00);
            var expected = true;

            var actual = manager.IsTimeSlotAvailable(defaultRoom, from, to);

            Assert.AreEqual<bool>(expected,actual);
        }

        [TestMethod()]
        public void IsBookedTimeSlotAvailableTest()
        {
            var r = defaultRoom.Reservations;
            var from = new DateTime(2018, 06, 01, 10, 00, 00);
            var to = new DateTime(2018, 06, 01, 12, 00, 00);
            var expected = false;

            var actual = manager.IsTimeSlotAvailable(defaultRoom, from, to);

            Assert.AreEqual<bool>(expected, actual);
        }



    }
}