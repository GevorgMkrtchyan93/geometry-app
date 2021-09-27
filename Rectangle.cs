using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Rectangle:Figure
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle(float width,float height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle()
        {
        }

        public override float Perimeter()
        {
          return Width*2+Height*2;
        }

        public override float Area()
        {
            return Width*Height;
        }
    }
}
