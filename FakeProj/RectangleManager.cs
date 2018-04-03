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

        //remove rectangle r from the manager and return true
        //if r is not in the manager, return false
        public bool removeItem(Rectangle r )
        {
            return rectList.Remove( r );
        }

        //remove an item from the manager and return true
        //if the manager is empty, return false
        public bool removeItem( )
        {
            if (isEmpty( ))
                return false;
            else
            {
                rectList.RemoveAt( rectList.Count - 1 );
                return true;
            }
        }

        //return true if the manager is empty
        public bool isEmpty( )
        {
            return rectList.Count == 0;
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

        //return the rectangle with the largest area
        //return null if the list is empty
        public Rectangle largestArea( )
        {
            if (rectList.Count == 0) return null;
            Rectangle target = rectList[ 0 ];
            foreach(Rectangle r in rectList)
            {
                if (target.getArea( ) < r.getArea( ))
                    target = r;
            }
            return target;
        }


    }
}
