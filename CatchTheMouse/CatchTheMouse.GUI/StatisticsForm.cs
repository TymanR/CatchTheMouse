using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatchTheMouse.Lib;

namespace CatchTheMouse.GUI
{
    public partial class StatisticsForm : Form
    {

        private static IUserLoadService userLoadService = new UserLoadService();
        private static IUserSaveService userSaveService = new UserSaveService();

       public UserManager userManager = new UserManager(userLoadService, userSaveService);
        
        public StatisticsForm()
        {
            InitializeComponent();
           List<User> users =  userManager.GetUsers(); 
         RefreshPlayerList();
        }


        public void RefreshPlayerList()
        {
            ShowPlayersBox.Items.Clear();

            List<User> users = userManager.GetUsersSortedByAura();

            foreach (User u in users)
            {
                ShowPlayersBox.Items.Add(u); 
            }


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SecondNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(FirstNameBox.Text) &&
      string.IsNullOrWhiteSpace(SecondNameBox.Text) |
      ShowPlayersBox.SelectedItem == null)
            {
                MessageBox.Show("Somebody forgot to write his name down or to choose his User.");
                return;
            }
            else
            {
                User _user = new User();
                _user.FirstName = FirstNameBox.Text;
                _user.SecondName = SecondNameBox.Text;
                userManager.AddUser(_user);

                ShowPlayersBox.Items.Clear();

                //foreach (User u in SortUsersByScore())
                //{
                //    ShowPlayersBox.Items.Add(u);
                //}


                this.Hide();
                LoginForm loginForm = new LoginForm(this,_user);
                loginForm.Show();
            }

        }


        public void SortUsersByScore()
        {

      

            // return sortedUsers;
        }

        private void ShowPlayersBox_SelectedIndexChanged(object sender, EventArgs e)
        {



        }



    }
}
