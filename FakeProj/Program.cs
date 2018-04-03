using System;


//updated code with additional functionality
//Lydia's code

namespace FakeProj
{
    class Program
    {
        static void Main( string[] args )
        {

            Random rnd = new Random( );
            //WHAT WE WANT...
            //RectangleManager rm = new RectangleManager( );
            //rm.add( new Rectangle( ) );
            //Console.WriteLine(rm);

            RectangleManager rm = new RectangleManager( );
            rm.addItem( new Rectangle( "R1" ) );

            int count = 2;
            string name = "R" + count;

            //loop to make some random rectangles
            for (int i = 0; i < 12; i++)
            {
                rm.addItem( new Rectangle( name, rnd.Next( ) % 12, rnd.Next( ) % 14 ) );
                count++;
                name = "R" + count;
            }

            //show all the rectangles in the manager
            Console.WriteLine( rm );

            Console.WriteLine( "now adding a new rectangle..." );
            rm.addItem( new Rectangle( "New Rectangle", 2, 4.5 ) );

            //show updated list
            Console.WriteLine( "Updated list..." );
            Console.WriteLine( rm );

            Console.WriteLine( "Removing a rectangle..." );
            rm.removeItem( );
            //show updated list
            Console.WriteLine( "Updated list..." );
            Console.WriteLine( rm );

            //find rectangle with the largest area
            Rectangle largest = rm.largestArea( );
            if (largest != null)
            {
                Console.WriteLine( largest + " is the largest rectangle." );
                //Removing largest
                Console.WriteLine( "Removing largest..." );
                rm.removeItem( largest );
                Console.WriteLine( "Updated list..." );
                Console.WriteLine( rm );
            }







        }
    }
}
