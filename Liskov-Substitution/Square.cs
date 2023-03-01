using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public class Square : Rectangle
    {
        public Square(int size) : base(size, size)
        {
        }

        public override int Width
        {
            get
            {
                return base.Width;
            }

            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
        public override int Height
        {
            get
            {
                return base.Height;
            }

            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
       
    }
}
