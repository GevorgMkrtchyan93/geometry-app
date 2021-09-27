using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Triangle : Figure
    {

        public float Basis { get;  set; }
        public float Height { get;  set; }
        public float FirstPage { get; set; }
        public float SecondPage { get; set; }
        public Triangle(float basis,float height,float firstPage,float secondPage)
        {
            Basis = basis;
            Height = height;
            FirstPage = firstPage;
            SecondPage = secondPage;
        }

        public override float Area()
        {
            return (float)1/2* Basis*Height;
        }

        public override float Perimeter()
        {
            return Basis + SecondPage + FirstPage; 
        }
    }
}
