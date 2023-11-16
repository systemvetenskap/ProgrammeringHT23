using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL10
{
    class Triangle : Shape
    {
        
        public Triangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override int Area()  // lägg till ordet ovverride
        {
            return Width * Height/2;
        }

    }
}
