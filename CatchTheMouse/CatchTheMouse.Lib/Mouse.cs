using CatchTheMouse.Lib;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CatchTheMouse.Lib
{
    public class Mouse : Player , IPlayer
    {
       public  override string PictureName => "jerry";
        public override bool IsVisible
        {
            get
            {
                int visible_in_moves = 2;
                int i = base.GetNumberOfMoves();

                if (i % visible_in_moves == 0)
                {
                    return true;
                }
                return false;
            }

        }

        public Mouse(PlayingArea playingArea) : base(playingArea)
        {

        }

        public override void Move()
        {

            Position position;

            do
            {
                MouseMove move = MouseMove.GetMove();

                position = new Position(Row + move.DeltaRow, Column + move.DeltaColumn);

            } while (_playingArea.IsValid(position) == false);

            Move(position);


        }




    }
}
