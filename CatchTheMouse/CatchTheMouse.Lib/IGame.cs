using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    internal interface IGame
    {

        IPlayer Mouse { get; }
        IPlayer[] Cats { get; }
        bool GameOver { get; }
        int Score { get; }

        void Play(Position catPosition);




    }
}
