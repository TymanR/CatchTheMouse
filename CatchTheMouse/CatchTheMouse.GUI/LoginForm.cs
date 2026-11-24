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
    public partial class LoginForm : Form
    {
        PlayingAreaForm _playingAreaForm;
        StatisticsForm _statisticsForm;
        private string _mouseBehaviour;
      private User _user;


        public string MouseBehaviour
        {
            get => _mouseBehaviour;
            set
            {
                _mouseBehaviour = value;

                if ( value == "default")
                {
                    label2.Text = "Default Mouse Behaviour";
                }
                else if (value == "goofy")
                {
                    label2.Text = "Goofy Mouse Behaviour";
                }
                else
                {
                    label2.Text = "Select Mouse Behaviour";
                }
            }
        }

        public LoginForm(StatisticsForm statisticsForm,User user)
        {
            InitializeComponent();
            //plForm = new form was here, and was null whole time, so i moved to btnStartG
            _playingAreaForm = null;
            _statisticsForm = statisticsForm;
          
            _user = user;

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (_mouseBehaviour == null)
            {
                MessageBox.Show("Choose Mouse Behaviour first");
            }
            else
            {
                this.Hide();
                _playingAreaForm = new PlayingAreaForm(_statisticsForm ,this, _user);
                _playingAreaForm.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MouseBehaviour = "goofy";

        }

        private void btnDefaultBehaviour_Click(object sender, EventArgs e)
        {
            MouseBehaviour = "default";
        }

       

        private void label2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
