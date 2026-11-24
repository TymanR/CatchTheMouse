using CatchTheMouse.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class Game
    {
        const int SCORE_MAX = 1000;
        // used ai to implement datetime and Score, i had no clue how to do it
        internal DateTime StartTime { get; } = DateTime.Now;
        private DateTime? _endTime;
        private int _moves;
        private int _seconds;
        private const int POINTS_PER_MOVE = 10;
        private User _user;
        private PlayingArea _playingArea;
        public IPlayer Mouse { get; }
        public IPlayer Cat { get; }

        private int ElapsedSeconds
        {
            get
            {
                DateTime end = _endTime ?? DateTime.Now;

                return (int)(end - StartTime).TotalSeconds;
            }
        }
        public int Score
        {
            get
            {
                int score = SCORE_MAX - (_moves * POINTS_PER_MOVE) - ElapsedSeconds;

                return Math.Max(0, score);
            }
        } 

       

        public bool GameOver
        {
            get
            {
                if ((Cat.Row == Mouse.Row) && (Cat.Column == Mouse.Column))
                {
                    return true;
                }
                return false;
            }
        }

     
        public Game(int rows, int columns , string mouseBehaviour, User user)
        {
           this._user = user;
            _playingArea = new PlayingArea(rows, columns);

            Cat = new Cat(_playingArea);
            if (mouseBehaviour == "goofy")
            {
                Mouse = new MouseGoofy(_playingArea);
            }
            else
            {
                Mouse = new Mouse(_playingArea);
            }






        }

      


        public void Play(Position catPosition)
        {

            Mouse.Move();

            Cat.Move(catPosition);

            if (GameOver == true)
            {
                return;
            }
           
            _moves++;

        }
      

    }
}
