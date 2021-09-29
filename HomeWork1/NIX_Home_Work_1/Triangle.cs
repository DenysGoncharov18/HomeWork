using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIX_Home_Work_1
{
     class Triangle: Rectangle
    {
        int gammaX, gammaY;
        public Triangle()
        {
            x = 0;
            y = 0;
            deltaX = 1;
            deltaY = 1;
            gammaX = 2;
            gammaY = 2;
        }
        public Triangle(int x, int y, int deltaX, int deltaY, int gammaX, int gammaY )
        {
            x = this.x;
            y = this.y;
            deltaX = this.deltaX;
            deltaY = this.deltaY;
            gammaX = this.gammaX;
            gammaY = this.gammaY;
        }
        public override void Print()
        {
            Console.WriteLine($"Triangle with conners in the next points: A ({x}:{y}) B({x + deltaX}:{y+ deltaY}) C({x + gammaX}:{y + gammaY})");

        }
        public override void Scope(int scopeRatio)
        {
            Console.WriteLine($"Scoped Triangle will have coners in the next points: " +
                $"A ({x}:{y}) B({x + (deltaX * scopeRatio)}:{y+(deltaY*scopeRatio)}) C({x + (gammaX * scopeRatio)}:{y + (gammaY * scopeRatio)})");
        }

        public override void Shift(int shiftX, int shiftY)
        {
            x += shiftX;
            y += shiftY;
            Console.WriteLine($"Scoped Triangle will have coners in the next points: " +
                $"A ({x}:{y}) B({x + deltaX}:{y + deltaY}) C({x + gammaX}:{y + gammaY})");
        }

    }
}
