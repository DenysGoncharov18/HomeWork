using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIX_Home_Work_1
{
    class Rectangle : Point
    {
        public int deltaX, deltaY;
        public Rectangle()
        {
            x = 0;
            y = 0;
            deltaX = 1;
            deltaY = 1;
        }
        public Rectangle(int x, int y, int deltaX, int deltaY)
        {
            x = this.x;
            y = this.y;
            deltaX = this.deltaX;
            deltaY = this.deltaY;
        }
        public override void Print()
        {
            Console.WriteLine($"Rectangle with conners in the next points: A ({x}:{y}) B({x+deltaX}:{y}) C({x+deltaX}:{y+deltaY}) D({x}:{y+deltaY})");
            
        }
        public override void Scope( int scopeRatio)
        {
            Console.WriteLine($"Scoped Rectangle will have coners in the next points: " +
                $"A ({x}:{y}) B({(x + deltaX)*scopeRatio}:{y}) C({(x + deltaX)*scopeRatio}:{(y + deltaY)*scopeRatio}) D({x}:{(y + deltaY)*scopeRatio})");
        }

        public override void Shift( int shiftX, int shiftY)
        {
            x += shiftX;
            y += shiftY;
            Console.WriteLine($"Scoped Rectangle will have coners in the next points: " +
                $"A ({x}:{y}) B({x + deltaX}:{y}) C({x + deltaX}:{y + deltaY}) D({x}:{y + deltaY})");
        }
    }
}
