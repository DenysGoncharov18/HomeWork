using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIX_Home_Work_1
{
    class Iamge : Rectangle
    {
     public   List<Point> figure = new List<Point>();
 //      public List<Point> Figure  {set; get;}
        public override void Print()
        {
            foreach (var item in figure)
            {
                item.Print();
            }
            
        }
        public override void Scope(int scopeRatio)
        {
            foreach (var item in figure)
            {
                item.Scope(scopeRatio);
            }
           
        }
        public override void Shift(int shiftX, int shiftY)
        {
            foreach (var item in figure)
            {
                item.Shift(shiftX, shiftY);
            }
           
        }
    }
}
