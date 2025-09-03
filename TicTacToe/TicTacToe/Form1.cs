using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };   //initializes array of characters representing Tic Tac Toe board, each index corresponds to a position on the board with '0' to '9' serving as placeholders for player moves
        static int player = 1;  //keeps track of current player starting with player 1 & toggling between player 1 and player 2 as game progresses
        static int choice;  //stores player's selected position on board & is updated based on user input during game
        static int flag = 0;    //determines state of game & can indicate whether game is ongoing, a player has won, or if it has ended in draw
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //when Tic Tac Toe board is loaded
        {
            lblPlayer.Text = "Player 1";    //sets up label to indicate it is Player 1's turn at the start
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
