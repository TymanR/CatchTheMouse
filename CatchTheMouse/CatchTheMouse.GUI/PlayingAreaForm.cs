using CatchTheMouse.GUI.Properties;
using CatchTheMouse.Lib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatchTheMouse.GUI
{
    public partial class PlayingAreaForm : Form
    {
        private const int ROWS = 4;
        private const int COLUMNS = 4;
        private const int BUTTON_SIZE = 84;
        private const string EMPTY_FIELD_PICTURE = "CTM";
        private const string MOUSE_CAUGHT_PICTURE = "tomcatchesjerry";

        private System.Windows.Forms.Timer _scoreTimer;
        private GameButton[,] _buttons;
        private FlowLayoutPanel flwPlayingArea;
        private Game _game;
        private Label lblScore;
        private LoginForm _loginForm;
        private User _user;
        private StatisticsForm _statisticsForm;
        public PlayingAreaForm(StatisticsForm statisticsForm,LoginForm loginForm, User user)
        {
            InitializeComponent();
            _statisticsForm = statisticsForm;

            _user = user;
          
            _loginForm = loginForm;
            _game = new Game(ROWS, COLUMNS, loginForm.MouseBehaviour, _user);

            CreateButtons();
            UpdateScore();
        }

        private void CreateButtons()
        {
            _buttons = new GameButton[ROWS, COLUMNS];

            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLUMNS; column++)
                {
                    _buttons[row, column] = CreateButton(row, column);
                    flwPlayingArea.Controls.Add(_buttons[row, column]);
                }

                flwPlayingArea.SetFlowBreak(_buttons[row, COLUMNS - 1], true);
            }
        }

        private GameButton CreateButton(int row, int column)
        {
            GameButton button = new GameButton(row, column);

            button.Width = BUTTON_SIZE;
            button.Height = BUTTON_SIZE;
            button.BackgroundImage = GetPicture(EMPTY_FIELD_PICTURE);
            button.BackgroundImageLayout = ImageLayout.Zoom;
            button.Click += GameButton_Click;

            return button;
        }


        private static Bitmap GetPicture(string pictureName)
        {
            object obj = Resources.ResourceManager.GetObject(pictureName);

            return (Bitmap)obj;
        }




        private void GameButton_Click(object sender, EventArgs e)
        {
            GameButton clickedButton = (GameButton)sender;

            _game.Play(new Position(clickedButton.Row, clickedButton.Column));

            RefreshBoard();
            UpdateScore();

            if (_game.GameOver)
            {
                EndGame();
            }
        }

        private void RefreshBoard()
        {
            ClearBoard();


            if (_game.Mouse.IsVisible)
            {
                ShowPlayer(_game.Mouse);
            }
            ShowPlayer(_game.Cat);
        }

       private void ClearBoard()
        {
            foreach (GameButton button in _buttons)
            {
                button.BackgroundImage = GetPicture(EMPTY_FIELD_PICTURE);
            }
        }

        private void ShowPlayer(IPlayer player)
        {
            _buttons[player.Row, player.Column].BackgroundImage = GetPicture(player.PictureName);
        }

        private void UpdateScore()
        {
            lblScore.Text = "Score: " + _game.Score;
        }



        private void EndGame()
        {
            _buttons[_game.Mouse.Row, _game.Mouse.Column]
                .BackgroundImage = GetPicture(MOUSE_CAUGHT_PICTURE);

            _user.UpdateDataOnGameFinished(_game);
            

            MessageBox.Show(
                "The mouse is caught! Your score: " + _game.Score,
                "Game over");

            _statisticsForm.userManager.SaveUsers();
            _statisticsForm.RefreshPlayerList();
            Close();
           _statisticsForm.Show();

        }



        private void InitializeComponent()
        {
            this.flwPlayingArea = new System.Windows.Forms.FlowLayoutPanel();
            this.lblScore = new System.Windows.Forms.Label();
            this.flwPlayingArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwPlayingArea
            // 
            this.flwPlayingArea.Controls.Add(this.lblScore);
            this.flwPlayingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwPlayingArea.Location = new System.Drawing.Point(0, 0);
            this.flwPlayingArea.Name = "flwPlayingArea";
            this.flwPlayingArea.Size = new System.Drawing.Size(284, 261);
            this.flwPlayingArea.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(3, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(44, 16);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "label1";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayingAreaForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.flwPlayingArea);
            this.Name = "PlayingAreaForm";
            this.flwPlayingArea.ResumeLayout(false);
            this.flwPlayingArea.PerformLayout();
            this.ResumeLayout(false);

        }




    }
}

