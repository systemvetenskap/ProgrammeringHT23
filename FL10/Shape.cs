using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL10
{
    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // Vi introducerar polymorfism

        public virtual int Area()  // lägg till ordet virtual
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

    }
}
