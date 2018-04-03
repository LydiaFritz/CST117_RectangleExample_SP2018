using System.Collections.Generic;

namespace FakeProj
{
    class RectangleManager
    {
        private List<Rectangle> rectList = new List<Rectangle>( );

        public void addItem( Rectangle r )
        {
            rectList.Add( r );
        }

        public override string ToString( )
        {
            string str = "";
            foreach (Rectangle r in rectList)
            {
                str += r.ToString( ) + "\n";
            }
            return str;
        }


    }
}
