using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class UserManager
    {

        //private const string FILENAME = "../../sigma_list";
        private static readonly string FILENAME = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "sigma_list"
        );

        private List<User> _users = new List<User>();
        private IUserSaveService _saveService;




        public UserManager(IUserLoadService loadService, IUserSaveService saveService)
        {
            _saveService = saveService;

           loadService.Load(FILENAME, _users);
            
        }



        public void AddUser(User user)
        {
            _users.Add(user);
        }


        public List<User> GetUsers()
        {
            return _users;
        }

  
        public Boolean SaveUsers()
        {
            try
            {
                _saveService.Save(FILENAME, _users);
            return true;
            }
            catch (Exception)
            {

                return false;
            }
          


        }

        public List<User> GetUsersSortedByAura()
        {
            User Theiler = _users.FirstOrDefault(u => u.FirstName == "Manfred" && u.SecondName == "Theiler"); 
            User Scheithe = _users.FirstOrDefault(u => u.FirstName == "Jakob" && u.SecondName == "Scheithe");

            List<User> sortedUsers = new List<User>();

            int theiler = 0;
            int scheithe = 0;


            foreach (User user in _users)
            {
                if (user.SecondName == "Theiler" && user.FirstName == "Manfred")
                {
                  theiler += 1;
                }
                if (user.SecondName == "Scheithe" && user.FirstName == "Jakob")
                {
                    scheithe += 1;
                }


                int index = 0;
                while (index < sortedUsers.Count && sortedUsers[index].HighScore >= user.HighScore)
                {
                    index++;
                }
                sortedUsers.Insert(index, user);
                //       ShowPlayersBox.Items.Add(sortedUsers);


            }

            if (Theiler != null || Scheithe != null)
            {
                Random _rnd = new Random();

                if (scheithe == 1 && theiler == 1)
                {
                    int TopUltraMegaSigmaDecision = _rnd.Next(0, 2);

                    if (TopUltraMegaSigmaDecision == 0)
                    {
                        sortedUsers.Insert(0, Scheithe);
                        sortedUsers.Insert(1, Theiler);  //can throw ArgumentOutOfRangeException if list empty
                    }
                    else
                    {
                        sortedUsers.Insert(0, Theiler);
                        sortedUsers.Insert(1, Scheithe);
                    }
                }
                else if (theiler == 1)
                {
                    sortedUsers.Insert(0, Theiler);
                }
                else if (scheithe == 1)
                {
                    sortedUsers.Insert(0, Scheithe);
                }
            }
          

            return sortedUsers;
        }




    }
}







