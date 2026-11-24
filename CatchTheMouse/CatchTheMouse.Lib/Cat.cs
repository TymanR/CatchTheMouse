using CatchTheMouse.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class Cat : Player , IPlayer
    {

        public override string PictureName => "tom";
        public Cat(PlayingArea playingArea) : base(playingArea)
        {

        }







    }
}
