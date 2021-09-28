using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIX_Home_Work_1
{
    abstract class Point
    {
        public int x, y;
        /// <summary>
        /// Printing poin by coordinates X and Y
        /// </summary>
        /// <param name="x">coordinate X</param>
        /// <param name="y">Coordinate Y</param>
        public abstract void Print();
        /// <summary>
        /// Change coordinates of point on shift ratio 
        /// </summary>
        /// <param name="x">starting X-coordinate</param>
        /// <param name="y">starting Y-coordinate</param>
        /// <param name="shiftX"> shift ratio of X-coordinate </param>
        /// <param name="shiftY">shift ratio of Y-coordinate</param>
        public abstract void Shift( int shiftX, int shiftY);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">starting X-coordinate</param>
        /// <param name="y">starting Y-coordinate</param>
        /// <param name="scopeRatio"></param>
        public abstract void Scope( int scopeRatio);

    }
}
