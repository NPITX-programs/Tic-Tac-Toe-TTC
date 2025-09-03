using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe;

namespace TicTacToeProject
{
    public partial class StartMenu : Form
    {
        private string selectedMode = "";

        public StartMenu()
        {
            InitializeComponent();
            this.Load += StartMenu_Load;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            selectedMode = "SinglePlayer";
            txtSinglePlayerName.Visible = true;
            txtPlayer1Name.Visible = false;
            txtPlayer2Name.Visible = false;
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            selectedMode = "Multiplayer";
            txtSinglePlayerName.Visible = false;
            txtPlayer1Name.Visible = true;
            txtPlayer2Name.Visible = true;
        }

        private void txtSinglePlayerName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPlayer1Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlayer2Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (txtSinglePlayerName.Visible)
            {
                string singlePlayerName = txtSinglePlayerName.Text;
                if (string.IsNullOrWhiteSpace(singlePlayerName))
                {
                    MessageBox.Show("Please enter your name to start the game.");
                    return;
                }

                gameUI gameForm = new gameUI("SinglePlayer", singlePlayerName);
                gameForm.Show();
                this.Hide();
            }
            else if (txtPlayer1Name.Visible && txtPlayer2Name.Visible)
            {
                string player1 = txtPlayer1Name.Text;
                string player2 = txtPlayer2Name.Text;

                if (string.IsNullOrWhiteSpace(player1) || string.IsNullOrWhiteSpace(player2))
                {
                    MessageBox.Show("Please enter both player names to start the game.");
                    return;
                }

                gameUI gameForm = new gameUI("Multiplayer", player1, player2);
                gameForm.Show();
                this.Hide();
            }

        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
          txtSinglePlayerName.Visible = false;
          txtPlayer1Name.Visible = false;
          txtPlayer2Name.Visible = false;
        }
    }
}
