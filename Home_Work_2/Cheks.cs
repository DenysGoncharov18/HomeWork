using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Home_Work_2
{
    [Serializable]
    class Cheks
    {
        public List<Check_In_Hotel> checks = new List<Check_In_Hotel>();
        public void CreateNewChekIn(Guest guest, Room room, DateTime checkIn, DateTime checkOut)
        {
            Check_In_Hotel visit = new Check_In_Hotel(guest, room, checkIn, checkOut);
            checks.Add(visit);
               
        }
        public void ShowChekIns()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            foreach (var item in checks)
            {
                Console.WriteLine($"Full Name {item.guest.fullName} number {item.room.number} checkIn {item.bookingIn} checkOut {item.bookingOut}");
            }
            Console.BackgroundColor = ConsoleColor.Blue;
        }
    }
}
