using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
   public class UserLoadService : IUserLoadService
    {

    
        private List<string> _lines = new List<string>();




        public bool Load(string filename, List<User> users)
        {
        
         

            try
            {
                using (StreamReader reader = new StreamReader($"{filename}"))
                {
                    while (!reader.EndOfStream)
                    {
                       
                    string line = reader.ReadLine();

                        _lines.Add(line);
                    }
                }

                foreach (string line in _lines)
                {
                
                    User user = new User();
                    string[] parts = line.Split(';');
                    // FirstN; SecondN; Score
                    user.FirstName = parts[0];
                    user.SecondName = parts[1];
                    user.HighScore = int.Parse(parts[2]);
                    users.Add(user);
                }


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }











        }
    }
}
