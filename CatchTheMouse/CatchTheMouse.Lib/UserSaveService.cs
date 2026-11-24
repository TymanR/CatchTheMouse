using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CatchTheMouse.Lib
{
 public class UserSaveService : IUserSaveService
    {





        public bool Save(string filename, List<User> users)
        {
          
         
            try
            {
                using (StreamWriter writer = new StreamWriter($"{filename}"))
                {
                    foreach (User user in users)
                    {
                        writer.WriteLine($"{user.FirstName};{user.SecondName};{user.HighScore}");
                    }

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
