namespace CatchTheMouse.GUI
{
    partial class LoginForm
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnDefaultBehaviour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoofyBehaviour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(247, 42);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(268, 200);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "start game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnDefaultBehaviour
            // 
            this.btnDefaultBehaviour.Location = new System.Drawing.Point(191, 314);
            this.btnDefaultBehaviour.Name = "btnDefaultBehaviour";
            this.btnDefaultBehaviour.Size = new System.Drawing.Size(144, 90);
            this.btnDefaultBehaviour.TabIndex = 1;
            this.btnDefaultBehaviour.Text = "Default";
            this.btnDefaultBehaviour.UseVisualStyleBackColor = true;
            this.btnDefaultBehaviour.Click += new System.EventHandler(this.btnDefaultBehaviour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mouse Behaviour";
            // 
            // btnGoofyBehaviour
            // 
            this.btnGoofyBehaviour.Location = new System.Drawing.Point(384, 314);
            this.btnGoofyBehaviour.Name = "btnGoofyBehaviour";
            this.btnGoofyBehaviour.Size = new System.Drawing.Size(157, 90);
            this.btnGoofyBehaviour.TabIndex = 3;
            this.btnGoofyBehaviour.Text = "Goofy";
            this.btnGoofyBehaviour.UseVisualStyleBackColor = true;
            this.btnGoofyBehaviour.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Mouse Behaviour";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGoofyBehaviour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDefaultBehaviour);
            this.Controls.Add(this.btnStartGame);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnDefaultBehaviour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoofyBehaviour;
        private System.Windows.Forms.Label label2;
    }
}