using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe;
using WindowsFormsApp1;

namespace TicTacToeProject
{
    public partial class frm_StartMenu : Form
    {
        private string selectedMode = "";

        public frm_StartMenu()
        {
            InitializeComponent();
            this.Load += frm_StartMenu_Load;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmFont fontform = new frmFont();
            fontform.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frm_AboutUs aboutForm = new frm_AboutUs();
            aboutForm.Show();
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

        private void frm_StartMenu_Load(object sender, EventArgs e)
        {
            // Hide all textboxes initially
            txtSinglePlayerName.Visible = false;
            txtPlayer1Name.Visible = false;
            txtPlayer2Name.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (selectedMode == "SinglePlayer")
            {
                string name = txtSinglePlayerName.Text;
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter your name to start the game.");
                    return;
                }

                frm_gameUI gameForm = new frm_gameUI("SinglePlayer", name);
                gameForm.Show();
                this.Hide();
            }
            else if (selectedMode == "Multiplayer")
            {
                string p1 = txtPlayer1Name.Text;
                string p2 = txtPlayer2Name.Text;

                if (string.IsNullOrWhiteSpace(p1) || string.IsNullOrWhiteSpace(p2))
                {
                    MessageBox.Show("Please enter both player names to start the game.");
                    return;
                }

                frm_gameUI gameForm = new frm_gameUI("Multiplayer", p1, p2);
                gameForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a game mode first.");
            }
        }
    }
}
