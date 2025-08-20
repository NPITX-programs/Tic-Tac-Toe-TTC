using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmFont : Form
    {
        public frmFont()
        {
            InitializeComponent();
        }


        private void btnColor_Click(object sender, EventArgs e)
        {
            if(cdColor.ShowDialog() == DialogResult.OK) //a method is used to display a Dialog box for selecting a color 
            {
                btnColor.ForeColor = cdColor.Color;  //to set the foreground color of a button
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if(cdColor.ShowDialog() == DialogResult.OK) //a method is used to display a Dialog box for selecting a color
            {
                btnQuit.ForeColor = cdColor.Color;   //to set the foreground color of a button 
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(cdColor.ShowDialog() == DialogResult.OK) //a method is used to display a Dialog box for selecting a color 
            {
                btnPause.ForeColor = cdColor.Color;  //to set the foreground color of a button
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if(cdColor.ShowDialog() == DialogResult.OK) //a method is used to display a Dialog box for selecting a color 
            {
                btnRestart.ForeColor = cdColor.Color; //to set the foreground color of a button 
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if(cdColor.ShowDialog() == DialogResult.OK) //a method is used to display a Dialog box for selecting a color
            {
                btnNewGame.ForeColor = cdColor.Color; //to set the foreground color of a button 
            }
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            if(cdColor.ShowDialog() == DialogResult.OK) //a method is used to display a Dialog box for selecting a color
            {
                btnSinglePlayer.ForeColor = cdColor.Color; //to set the foreground color of a button
            }
        }

        private void btnMultiPlayer_Click(object sender, EventArgs e)
        {
            if(cdColor.ShowDialog() == DialogResult.OK) //a method is used to display a Dialog box for selecting a color
            {
                btnMultiPlayer.ForeColor = cdColor.Color; //to set the foreground color of a button
            }
        }

        private void frmFont_Load(object sender, EventArgs e)
        {

        }
    }
}
