using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class User
    {

        public DateTime lastGameDate;
       public string FirstName { get; set; }
       public string SecondName {  get; set; }

        public int HighScore { get; set; } 


          
        //future features. To be able to see all User's high scores to see how he progresssed over the time
       //public List<int> HighScore {  get; set; }



        public User()
        {


        }


        public void UpdateDataOnGameFinished(Game game)
        {


            if (game.Score > HighScore)
            {
              HighScore = game.Score;
            }
           
            lastGameDate = game.StartTime;


            //if (game.Score > HighScore[HighScore.Count - 1])
            //{
            //    HighScore.Add(game.Score);
            //}
           
        
        }


        public override string ToString()
        {
            return $"{FirstName} {SecondName}'s high score:{HighScore} ";
        }


    }
}
