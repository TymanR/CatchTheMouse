using CatchTheMouse.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class PlayingArea
    {
        internal int Rows { get; }
        internal int Columns { get; }


        internal PlayingArea(int rows, int columns)
        {

            Rows = rows;
            Columns = columns;

        }



        internal bool IsValid(Position position)
        {

            if (
                position.Row < Rows && position.Column < Columns &&
               position.Row >= 0 && position.Column >= 0
                )
            {
                return true;
            }

            return false;


        }





    }
}
