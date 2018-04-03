using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeProj
{
    class Rectangle
    {

        public double Width { set; get; }
        public double Length { set; get; }

        public double getArea( ) { return Width * Length; }
        public override string ToString( )
        {
            return "[" + Width + "," + Length + "]";
        }
    }
}
