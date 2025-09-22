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
    public partial class frm_gameUI : Form
    {

        private string player1Name;
        private string player2Name;
        private string gameMode;
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };   //initializes array of characters representing Tic Tac Toe board, each index corresponds to a position on the board with '0' to '9' serving as placeholders for player moves
        static int player = 1;  //keeps track of current player starting with player 1 & toggling between player 1 and player 2 as game progresses
        static int choice;  //stores player's selected position on board & is updated based on user input during game
        static int flag = 0;    //determines state of game & can indicate whether game is ongoing, a player has won, or if it has ended in draw
        public frm_gameUI()
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


        private void btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int index = int.Parse(clickedButton.Tag.ToString());

            if (arr[index] != 'X' && arr[index] != 'O')
            {
                arr[index] = player == 1 ? 'X' : 'O';
                clickedButton.Text = arr[index].ToString();
                flag = CheckWin();

                if (flag == 1)
                {
                    MessageBox.Show($"Player {(player == 1 ? player1Name : player2Name)} wins!");
                    ResetGame();
                }
                else if (flag == -1)
                {
                    MessageBox.Show("It's a draw!");
                    ResetGame();
                }
                else
                {
                    player = (player % 2) + 1;
                    lblPlayer.Text = $"Player {(player == 1 ? player1Name : player2Name)}";
                }
            }
        }


        private int CheckWin()
        {
            int[,] winPatterns = new int[,]
            {
        {0,1,2}, {3,4,5}, {6,7,8}, // rows
        {0,3,6}, {1,4,7}, {2,5,8}, // columns
        {0,4,8}, {2,4,6}           // diagonals
            };

            for (int i = 0; i < winPatterns.GetLength(0); i++)
            {
                int a = winPatterns[i, 0];
                int b = winPatterns[i, 1];
                int c = winPatterns[i, 2];

                if (arr[a] == arr[b] && arr[b] == arr[c])
                    return 1; // win
            }

            if (arr.All(x => x == 'X' || x == 'O'))
                return -1; // draw
            return 0; // game continues
        }


        private void ResetGame()
        {
            for (int i = 0; i < 9; i++)
            {
                arr[i] = char.Parse(i.ToString());
                Controls.Find($"btn{i}", true)[0].Text = "";
            }
            player = 1;
            lblPlayer.Text = $"Player 1: {player1Name}";
            flag = 0;
        }


        public frm_gameUI(string mode, string p1, string p2 = "")
        {
            InitializeComponent();
            gameMode = mode;
            player1Name = p1;
            player2Name = p2;

            if (gameMode == "SinglePlayer")
            {
                lblPlayer.Text = $"Player: {player1Name}";
            }
            else
            {
                lblPlayer.Text = $"Player 1: {player1Name}";
            }
        }
    }

}

