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
        int TurnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        bool checkX = true;

        private void play(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (checkX)
            {
                b.Text = "X";
                checkX = false;
            }
            else
            {
                b.Text = "O";
                checkX = true;
            }
            b.Enabled = false;
            TurnCount++;
            CheckForWinner();
        }

        private void CheckForWinner()
        {
            bool ThereIsAWinner = false;
            if (a1.Text == a2.Text && a2.Text == a3.Text && !a1.Enabled)
            {
                ThereIsAWinner = true;
            }
            else if (b1.Text == b2.Text && b2.Text == b3.Text && !b1.Enabled)
            {
                ThereIsAWinner = true;
            }
            else if (c1.Text == c2.Text && c2.Text == c3.Text && !c1.Enabled)
            {
                ThereIsAWinner = true;
            }

            else if (a1.Text == b1.Text && b1.Text == c1.Text && !a1.Enabled)
            {
                ThereIsAWinner = true;
            }
            else if (a2.Text == b2.Text && b2.Text == c2.Text && !a2.Enabled)
            {
                ThereIsAWinner = true;
            }
            else if (a3.Text == b3.Text && b3.Text == c3.Text && !a3.Enabled)
            {
                ThereIsAWinner = true;
            }

            else if (a1.Text == b2.Text && b2.Text == c3.Text && !a1.Enabled)
            {
                ThereIsAWinner = true;
            }
            else if (a3.Text == b2.Text && b2.Text == c1.Text && !a3.Enabled)
            {
                ThereIsAWinner = true;
            }

            if (ThereIsAWinner)
            {
                if (checkX == false)
                    MessageBox.Show("X Wins!!");
                else
                    MessageBox.Show("O Wins!!");
                ResetGame();
            }
            if (TurnCount == 9)
            {
                MessageBox.Show("Match Draw!!");
                ResetGame();
            }
        }

        private void ResetGame()
        {
            try
            {
                foreach (Button btn in Controls)
                {
                    btn.Text = "";
                }
            }
            catch { }
            try
            {
                foreach (Button btn in Controls)
                {
                    btn.Enabled = true;
                }
            }
            catch { }
            checkX = true;
            TurnCount = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
