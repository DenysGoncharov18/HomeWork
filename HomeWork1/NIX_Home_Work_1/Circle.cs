using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIX_Home_Work_1
{
    class Circle : Point
    {
        int radius;
        public Circle()
        {
            x = 0;
            y = 0;
            radius = 1; 
        }
        public Circle(int x, int y, int radius)
        {
            x = this.x;
            y = this.y;
            radius = this.radius;
        }
        public override void Print()
        {
            Console.WriteLine($"Circle with center in point {x}:{y} and radius {radius}");
        }
        public override void Scope( int scopeRatio)
        {
            Console.WriteLine($"Circle with center in point {x}:{y} and radius {radius * scopeRatio}");
        }

        public override void Shift( int shiftX, int shiftY)
        {
            Console.WriteLine($"Circle with center in point {x+shiftX}:{y+shiftY} and radius {radius}");
        }

    }
}
