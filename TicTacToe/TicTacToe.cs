using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;
using TicTacToe.Context;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private string _player;
        public TicTacToe(string playerName)
        {
            InitializeComponent();
            _player = playerName;
        }

        TicTacToeDbContext context = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(211, 211, 211);

            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item is Button && item.Name.Contains("btn"))
                {
                    item.Text = string.Empty;
                    item.Enabled = false;
                }
            }

            lblPlayer1.ForeColor = Color.Green;
            lblPlayer2.ForeColor = Color.Black;

            btnReset.Enabled = false;

            lblPlayer1Score.Text = "0";
            lblPlayer2Score.Text = "0";

            currentPlayer = Player.X;

            LeaderBoardList();

            lblPlayer1Text.Text = _player + ":";
            lblPlayer1.Text = _player + "  -  X";
        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {

            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item is Button && item.Name.Contains("btn"))
                {
                    item.Enabled = true;
                    item.Text = string.Empty;
                }
            }

            lblPlayer1.ForeColor = Color.Green;
            lblPlayer2.ForeColor = Color.Black;

            btnReset.Enabled = true;
            buttonEnabledCount = 0;
            currentPlayer = Player.X;
        }

        enum Player { X, O }
        Player currentPlayer;
        int buttonEnabledCount = 0;
        private void btnA1_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (currentPlayer == Player.X)
            {
                lblPlayer2.ForeColor = Color.Green;
                lblPlayer1.ForeColor = Color.Black;

                clickedButton.Text = "X";

                CheckWinner(currentPlayer);

                currentPlayer = Player.O;

            }
            else
            {
                lblPlayer1.ForeColor = Color.Green;
                lblPlayer2.ForeColor = Color.Black;

                clickedButton.Text = "O";

                CheckWinner(currentPlayer);
                 
                currentPlayer = Player.X;
            }


            clickedButton.Enabled = false;
            buttonEnabledCount++;

            if (buttonEnabledCount == 9)
            {
                MessageBox.Show("Tie!");
                return;
            }
        }

        int player1Score;
        int player2Score;
        private void CheckWinner(Player player)
        {
            var user = context.Players.FirstOrDefault(p => p.UserName == _player);

            bool winner =
                WinnerFound(btnA1, btnA2, btnA3) || // Horizontal checks
                WinnerFound(btnB1, btnB2, btnB3) ||
                WinnerFound(btnC1, btnC2, btnC3) ||
                WinnerFound(btnA1, btnB1, btnC1) || // Vertical checks
                WinnerFound(btnA2, btnB2, btnC2) ||
                WinnerFound(btnA3, btnB3, btnC3) ||
                WinnerFound(btnA1, btnB2, btnC3) || // Diagonal checks
                WinnerFound(btnA3, btnB2, btnC1);

            if (winner)
            {
                if (player == Player.X)
                {
                    player1Score += 1;
                    lblPlayer1Score.Text = player1Score.ToString();

                    if (player1Score == 3)
                    {
                        if (user != null)
                        {
                            user.WonRounds++;
                            context.SaveChanges();
                            LeaderBoardList();
                        }

                        MessageBox.Show($"{_player} Won!!!!!!");
                        ResetScores();
                    }
                    else
                    {
                        if (user != null)
                        {
                            user.WonRounds++;
                            context.SaveChanges();
                            LeaderBoardList();
                        }

                        MessageBox.Show($"{_player} Wins the round!");
                        ButtonsEnabled();
                    }
                }
                else
                {
                    player2Score += 1;
                    lblPlayer2Score.Text = player2Score.ToString();

                    if (player2Score == 3)
                    {
                        MessageBox.Show("Player2 Won!!!!!!");
                        ResetScores();
                    }
                    else
                    {
                        MessageBox.Show("Player2 Wins the round!");
                        ButtonsEnabled();
                    }
                }

            }
        }


        private bool WinnerFound(Button btn1, Button btn2, Button btn3)
        {
            bool result = (btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (!string.IsNullOrEmpty(btn1.Text));
            return result;
        }

        private void ResetScores()
        {
            player1Score = 0;
            player2Score = 0;
            lblPlayer1Score.Text = "0";
            lblPlayer2Score.Text = "0";
        }
        private void ButtonsEnabled()
        {
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item is Button && item.Name.Contains("btn"))
                {
                    item.Enabled = false;
                }
            }
        }

        private void LeaderBoardList()
        {
            dgvRank.DataSource = context.Players.Select(p => new { Player = p.UserName, p.WonRounds }).OrderByDescending(x => x.WonRounds).ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form1_Load(null, EventArgs.Empty);
        }
    }
}
