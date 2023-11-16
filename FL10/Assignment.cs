using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace FL10
{
    class Assignment 
    {
        // Vår assignment ÄR inte en figur
        // Men den HAR figurer
        public List<Shape> Shapes { get; set; } = new List<Shape>();
        public int Area => TotalArea();
        public string Id { get; set; }
        public Assignment(string id)
        {
            Id = id;
        }
        public int TotalArea()
        {
            int totalArea = 0;
            foreach (Shape shape in Shapes)
            {
                totalArea += shape.Area();
            }
            return totalArea;
        }
    }
}
