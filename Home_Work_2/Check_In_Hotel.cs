using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_2
{
    class Check_In_Hotel
    {
        public Guest guest;
        public Room room;
        public DateTime bookingIn;
        public DateTime bookingOut;
        public Check_In_Hotel(Guest guest, Room room, DateTime bookingIn, DateTime bookingOut)
        {
            this.guest = guest;
            this.room = room;
            this.bookingIn = bookingIn;
            this.bookingOut = bookingOut;
        }
    }
}
