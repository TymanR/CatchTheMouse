namespace CatchTheMouse.GUI
{
    partial class StatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.SecondNameBox = new System.Windows.Forms.TextBox();
            this.ShowPlayersBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(336, 363);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(105, 22);
            this.StartGameButton.TabIndex = 2;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(376, 260);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 22);
            this.FirstNameBox.TabIndex = 3;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.FirstNameBox_TextChanged);
            // 
            // SecondNameBox
            // 
            this.SecondNameBox.Location = new System.Drawing.Point(376, 313);
            this.SecondNameBox.Name = "SecondNameBox";
            this.SecondNameBox.Size = new System.Drawing.Size(100, 22);
            this.SecondNameBox.TabIndex = 4;
            this.SecondNameBox.TextChanged += new System.EventHandler(this.SecondNameBox_TextChanged);
            // 
            // ShowPlayersBox
            // 
            this.ShowPlayersBox.FormattingEnabled = true;
            this.ShowPlayersBox.ItemHeight = 16;
            this.ShowPlayersBox.Location = new System.Drawing.Point(136, 23);
            this.ShowPlayersBox.Name = "ShowPlayersBox";
            this.ShowPlayersBox.Size = new System.Drawing.Size(340, 180);
            this.ShowPlayersBox.TabIndex = 5;
            this.ShowPlayersBox.SelectedIndexChanged += new System.EventHandler(this.ShowPlayersBox_SelectedIndexChanged);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowPlayersBox);
            this.Controls.Add(this.SecondNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox SecondNameBox;
        private System.Windows.Forms.ListBox ShowPlayersBox;
    }
}