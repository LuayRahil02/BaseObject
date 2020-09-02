using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseobject 
{
    class Triangle : Shape
    {
         public Triangle (int width, int height) : base(width, height)
        { 
        }
        public int Area()
        {
            int Area = height * width / 2;
            return Area;

        }

        public int Circumferance()
        {
            int Circumferance = height + width * 2;
            return Circumferance;
        }

    }
}
