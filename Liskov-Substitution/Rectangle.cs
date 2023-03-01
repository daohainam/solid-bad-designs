using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle(int width, int height) { 
            Width = width;
            Height = height;
        }

        public int GetArea()
        {
            return Width * Height;
        }
    }
}
