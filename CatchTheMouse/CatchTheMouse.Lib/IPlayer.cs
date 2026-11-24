using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CatchTheMouse.Lib
{
    public interface IPlayer
    {
        int Row { get; }
        int Column { get; }

        string PictureName { get; }

        bool IsVisible { get; }
        void Move();
        void Move(Position position);
     





    }
}
