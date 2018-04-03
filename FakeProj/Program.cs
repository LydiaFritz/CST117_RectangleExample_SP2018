using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeProj
{
    class Program
    {
        static void Main( string[] args )
        {
            //WHAT WE WANT...
            //RectangleManager rm = new RectangleManager( );
            //rm.add( new Rectangle( ) );
            //Console.WriteLine(rm);

            RectangleManager rm = new RectangleManager( );
            rm.addItem( new Rectangle( ) );
            Console.WriteLine(rm.ToString());



        }
    }
}
