using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class MouseGoofy : Player , IPlayer
    {



        private const string PICTURE_NAME = "jerry2";
        private const int STEP_SIZE = 2;
        private const int FRIGHT_EVERY_N_MOVES = 5;
        
        public override string PictureName => PICTURE_NAME;

        public override bool IsVisible
        {
            get
            {
                return true;
            }
        }

        public MouseGoofy(PlayingArea playingArea) : base(playingArea)
        {

        }
        
        public override void Move()
        {
            if (IsFrightened())
            {
                Move(new Position(Row, Column));
                return;
            }

            MouseMove move = MouseMove.GetMove();
            
            int row = Wrap(Row + STEP_SIZE * move.DeltaRow, _playingArea.Rows);
            int column = Wrap(Column + STEP_SIZE * move.DeltaColumn, _playingArea.Columns);

            Move(new Position(row, column));
        }

        private bool IsFrightened()
        {
            return (GetNumberOfMoves() + 1) % FRIGHT_EVERY_N_MOVES == 0;
        }

        private static int Wrap(int value, int size)
        {
            return ((value % size) + size) % size;
        }
    }
}


