using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03
{
    internal class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle()
        {
            Width = Height = 0;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Width = height;
        }

        public Rectangle(int value)
        {
            Width = Height = value;
        }

        public override string ToString()
        {
            return $"Rectangle Dimensions {Width}, {Height}";
        }

    }
}
