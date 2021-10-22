using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Home_Work_2
{
    [Serializable]
    class Guests
    {
        public List<Guest> guests = new List<Guest>();

        public void CreateNewGuest()
        {
            Console.WriteLine("Enter full name of guest:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter number of passport");
            int passportNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Day of Birth");
            DateTime dayOfBirth = DateTime.Parse(Console.ReadLine());
            guests.Add(new Guest(fullName, passportNumber, dayOfBirth));
        }

        public Guest SearchGuest(int numberOfPassport)
        {
            return guests.Find(x => x.passportNumber.Equals(numberOfPassport));
        }
            public void ShowGuests()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            foreach (var item in guests)
            {
                Console.WriteLine($"Full name {item.fullName} number of passport {item.passportNumber} day of birth {item.dayOfBirth}");
            }
            Console.BackgroundColor = ConsoleColor.Green;
        }
        
    }
}
