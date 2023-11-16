using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL10
{
    class Square : Shape
    {
        public Square(int size)
        {
            Width = size;
            Height = size;
        }

        public override string ToString()
        {
            return $"Fyrkant ({Width},{Height})";
        }
    }
}
