using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure triangle = new Triangle(12,6,4,7);
            triangle.Area();
            triangle.Perimeter();
            Console.WriteLine($"Triangle area:{ triangle.Area()}\nTriangle Perimeter:{triangle.Perimeter()}");
            Figure rectangle = new Rectangle(10,14);
            rectangle.Area();
            rectangle.Perimeter();
            Console.WriteLine($"Rectangle area:{rectangle.Area()}\nTriangle Perimeter:{rectangle.Perimeter()}");
            Console.ReadLine();
        }
    }
}
