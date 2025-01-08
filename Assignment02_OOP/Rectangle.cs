using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_OOP
{
    internal class Rectangle
    {
        #region Properties
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set
            {
                //width= value >=0 ? value :  Console.WriteLine("Width cannot be negative.");
                if (value >= 0)
                    width = value;
                else
                    Console.WriteLine("Width cannot be negative.");
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else
                    Console.WriteLine("Height cannot be negative.");
            }
        }

        public double Area => width * height;
        #endregion

        #region Methods


        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {width}, Height: {height}, Area: {Area}");
        }
        #endregion


    }
}
