namespace WindowsFormsApp1
{
    partial class frmFont
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
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnMultiPlayer = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Lime;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(471, 108);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(93, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "START";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Aquamarine;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(471, 219);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(93, 23);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Violet;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(454, 322);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(119, 23);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.BackColor = System.Drawing.Color.Pink;
            this.btnSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePlayer.Location = new System.Drawing.Point(438, 371);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(152, 23);
            this.btnSinglePlayer.TabIndex = 6;
            this.btnSinglePlayer.Text = "SINGLE PLAYER";
            this.btnSinglePlayer.UseVisualStyleBackColor = false;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // btnMultiPlayer
            // 
            this.btnMultiPlayer.BackColor = System.Drawing.Color.Yellow;
            this.btnMultiPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiPlayer.Location = new System.Drawing.Point(438, 427);
            this.btnMultiPlayer.Name = "btnMultiPlayer";
            this.btnMultiPlayer.Size = new System.Drawing.Size(152, 23);
            this.btnMultiPlayer.TabIndex = 7;
            this.btnMultiPlayer.Text = "MULTIPLAYER";
            this.btnMultiPlayer.UseVisualStyleBackColor = false;
            this.btnMultiPlayer.Click += new System.EventHandler(this.btnMultiPlayer_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(471, 163);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(93, 23);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(460, 271);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(113, 23);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // frmFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnMultiPlayer);
            this.Controls.Add(this.btnSinglePlayer);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFont";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnMultiPlayer;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnRestart;
    }
}

