using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_2
{
    class Guest
    {
       public string fullName;
       public int passportNumber;
       public DateTime dayOfBirth;
        public Guest(string fullName, int passportNumber, DateTime dayOfBirth)
        {
            this.fullName = fullName;
            this.passportNumber = passportNumber;
            this.dayOfBirth = dayOfBirth;
        }
       
    }
}
