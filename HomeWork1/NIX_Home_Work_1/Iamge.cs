using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIX_Home_Work_1
{
    class Iamge : Rectangle
    {
        dinamic figure;
        public Iamge(dinamic figure)
        {
            figure = this.figure;
        }
        public override void Print()
        {
            figure.Print();
        }
        public override void Scope(int scopeRatio)
        {
            figure.Scope(scopeRatio);
        }
        public override void Shift(int shiftX, int shiftY)
        {
            figure.Shift(shiftX, shiftY);
        }
    }
}
