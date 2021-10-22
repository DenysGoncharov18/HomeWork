using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace Home_Work_2
{
    class Program
    {
        public void Serializator(Rooms roomsList, Guests guestsList, Cheks cheks)
        {

        }


        static void Main(string[] args)
        {

            Guest foundedGuest;
            Room foundedRoom;

            Rooms roomsList = new Rooms();
            Guests guestsList = new Guests();
            Cheks cheks = new Cheks();


            // Десериализация из файла


            StreamReader fileReaderRooms = File.OpenText(@"RoomsList.json");
            JsonSerializer serializerRooms = new JsonSerializer();
            roomsList = (Rooms)serializerRooms.Deserialize(fileReaderRooms, typeof(Rooms));

            fileReaderRooms.Close();

            StreamReader fileReaderGuests = File.OpenText(@"GuestsList.json");
            JsonSerializer serializerGuests = new JsonSerializer();
            guestsList = (Guests)serializerGuests.Deserialize(fileReaderGuests, typeof(Guests));

            fileReaderGuests.Close();


            StreamReader fileReaderChecks = File.OpenText(@"CheckInList.json");
            JsonSerializer serializerChecks = new JsonSerializer();
            cheks = (Cheks)serializerChecks.Deserialize(fileReaderChecks, typeof(Cheks));

            fileReaderChecks.Close();


            string choose = "start";
            while (choose != "finish")
            {
                Console.WriteLine("Choose ctegory: \n 1 - Rooms; \n 2 - Guests \n 3 - Cheks \n finish - if youwant  to leave");
                choose = Console.ReadLine();
                if (choose == "1")
                {

                    Console.WriteLine($"We start to work with \"Rooms\"");
                    string r = "some";
                    while (r != "back")
                    {
                        Console.WriteLine("Choose: \n 1 - to create room \n 2 - Show rooms \n back - to return ");
                        r = Console.ReadLine();
                        if (r == "1")
                        {
                            roomsList.CreateNewRoom();
                        }
                        if (r == "2")
                        {
                            roomsList.ShowRooms();
                        }
                    }

                }
                else if (choose == "2")
                {

                    Console.WriteLine($"We start work with \"Guests\"");
                    string r = "some";
                    while (r != "back")
                    {
                        Console.WriteLine("Choose: \n 1 - to create guest \n 2 - Show guest \n back - to return ");
                        r = Console.ReadLine();
                        if (r == "1")
                        {
                            guestsList.CreateNewGuest();
                        }
                        if (r == "2")
                        {
                            guestsList.ShowGuests();
                        }
                    }

                }
                else if (choose == "3")
                {

                    Console.WriteLine($"We start work with \"Cheks\"");

                    string r = "some";
                    while (r != "back")
                    {
                        Console.WriteLine("Choose: \n 1 - to create CheckIn \n 2 - Show CheckIns \n back - to return ");
                        r = Console.ReadLine();
                        if (r == "1")
                        {
                            Console.WriteLine("Enter passport number");
                            int passportNumber = int.Parse(Console.ReadLine());

                            if (guestsList.SearchGuest(passportNumber) != null)
                            {
                                foundedGuest = guestsList.SearchGuest(passportNumber);
                            }
                            else
                            {
                                Console.WriteLine($"There are no guests with paassport number {passportNumber}. You should create new guest");
                                guestsList.CreateNewGuest();
                                foundedGuest = guestsList.SearchGuest(passportNumber);
                            }

                            Console.WriteLine("enter room number");
                            int roomNumber = int.Parse(Console.ReadLine());

                            if (roomsList.SearchRoom(roomNumber) != null)
                            {
                                foundedRoom = roomsList.SearchRoom(roomNumber);
                            }
                            else
                            {
                                Console.WriteLine($"There is no room with number {roomNumber}. You should create new room");
                                roomsList.CreateNewRoom();
                                foundedRoom = roomsList.SearchRoom(roomNumber);
                            }

                            Console.WriteLine("Enter day of checkIn");
                            DateTime bookingIn = DateTime.Parse(Console.ReadLine());


                            Console.WriteLine("Enter day of checkOut");
                            DateTime bookingOut = DateTime.Parse(Console.ReadLine());
                            cheks.CreateNewChekIn(foundedGuest, foundedRoom, bookingIn, bookingOut);

                        }

                        if (r == "2")
                        {
                            cheks.ShowChekIns();

                        }

                    }
                }
                // Сериализация в файл
                StreamWriter fileRooms = File.CreateText(@"RoomsList.json");
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(fileRooms, roomsList);
                fileRooms.Close();

                StreamWriter fileGuests = File.CreateText(@"GuestsList.json");
                JsonSerializer serializerGuests1 = new JsonSerializer();
                serializerGuests1.Serialize(fileGuests, roomsList);
                fileGuests.Close();

                StreamWriter fileChecks = File.CreateText(@"CheckInList.json");
                JsonSerializer serializerChecks1 = new JsonSerializer();
                serializerChecks1.Serialize(fileChecks, roomsList);
                fileChecks.Close();


                //Console.ReadKey();

            }
        }
    }
}
