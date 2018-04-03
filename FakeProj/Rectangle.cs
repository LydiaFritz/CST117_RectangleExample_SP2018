using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeProj
{
    class Rectangle
    {
        //added a constructor
        public Rectangle(string name, 
            double length = 0.0, 
            double width = 0.0 )
        {
            this.Name = name;
            this.Length = length;
            this.Width = width;
        }


        //added a name attribute
        public string Name { set; get; }
        public double Width { set; get; }
        public double Length { set; get; }

        public double getArea( ) { return Width * Length; }
        public override string ToString( )
        {
            return Name + " [" + Width + "," + Length + "]";
        }
    }
}
