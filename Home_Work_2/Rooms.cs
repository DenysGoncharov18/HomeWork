using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Home_Work_2
{
    [Serializable]
    class Rooms
    {
        public List<Room> rooms = new List<Room>();
        public void CreateNewRoom()
        {
            Console.WriteLine("Enter number of the room:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter category of the room");
            string category = Console.ReadLine();
            Console.WriteLine("How much cost the room");
            decimal price = Decimal.Parse(Console.ReadLine());
            rooms.Add(new Room(n, category, price));
        }

        public Room SearchRoom(int numberOfRoom)
        {
            return rooms.Find(x => x.number.Equals(numberOfRoom));
        }
        public void ShowRooms()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            foreach (var item in rooms)
            {
                Console.WriteLine($"Room category {item.category} number{item.number} price is {item.price}");
            }
            Console.BackgroundColor = ConsoleColor.Yellow;
        }
    }
}
