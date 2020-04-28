using System;
namespace Game
{
    public struct Free_Location
    {
        public int Col{ get; set; }

        public int Row{ get; set; }

        public Free_Location(int r, int c){            
            Row = r;
            Col = c;
        }
    }
}
