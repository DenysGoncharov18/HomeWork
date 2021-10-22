using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_2
{
    class Room
    {
        public int number;
        public string category;
        public decimal price;
        
       public Room(int number, string category, decimal price)
       {
            this.number =number;
            this.category = category;
            this.price = price;        
       }
        
    }
}
