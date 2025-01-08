using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_OOP
{
    internal struct Point
    {
        #region Attributes
        public double X { get; set; }
        public double Y { get; set; }
        #endregion


        #region Constructor
        public Point()
        {
            
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }


        #endregion

        #region Methods
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        #endregion
    }
}
