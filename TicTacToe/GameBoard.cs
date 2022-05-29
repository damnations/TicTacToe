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
    public partial class GameBoard : Form
    {
        public GameBoard()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            button11.Text = string.Empty;
            button12.Text = string.Empty;
            button13.Text = string.Empty;
            button21.Text = string.Empty;
            button22.Text = string.Empty;
            button23.Text = string.Empty;
            button31.Text = string.Empty;
            button32.Text = string.Empty;
            button33.Text = string.Empty;
        }

        private void buttons_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttons_MouseHover(object sender, EventArgs e)
        {
            if (button11.Text == string.Empty)
            {
                button11.BackColor = Color.Green;
            }
            else if (button11.Text != string.Empty)
            {
                button11.BackColor = Color.Red;
            }
        }

        private void buttons_MouseLeave(object sender, EventArgs e)
        {
            if (button11.Text == string.Empty)  
            button11.BackColor = Button.DefaultBackColor;
        }
    }
}
