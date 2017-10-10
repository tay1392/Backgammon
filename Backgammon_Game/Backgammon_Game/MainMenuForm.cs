using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon_Game
{
    public partial class MainMenuForm : Form
    {
        private Driver NewGame;
        private int points;

        public MainMenuForm()
        {
            InitializeComponent();
            points = 1;
          
        }

        private bool Settings()
        {
            if(Player1Name_TB.Text == Player2Name_TB.Text)
            {
                MessageBox.Show("Players cannot have the same Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public Driver GetNewGame()
        {
            return NewGame;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (Settings())
            {
                //create new players
                Person[] players = new Person[2];
                //set their names and colors
                players[0] = new Person(Player1Name_TB.Text, System.Drawing.Color.White, +1, Rb_AI1.Checked);
                players[1] = new Person(Player2Name_TB.Text, System.Drawing.Color.Black, -1, Rb_AI2.Checked);
                //instantiate "people"
                Person.CreateOpponents(players[0], players[1]);
                //finally, create a new game with the Game Driver class
                NewGame = new Driver(players, points);
                Close();
            }
        }

        private void Player1Name_TB_TextChanged(object sender, EventArgs e)
        {
            Rb_AI1.Text = Player1Name_TB.Text;
        }

        private void Player2Name_TB_TextChanged(object sender, EventArgs e)
        {
            Rb_AI2.Text = Player2Name_TB.Text;
        }

        private void Rb_AI1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rb_AI2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rb_No_AI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonPoints_CheckedChanged(object sender, EventArgs e)
        {
            points = Int32.Parse(RadioButtonPoints.Text);
        }

        private void Rb1_CheckedChanged(object sender, EventArgs e)
        {
            points = Int32.Parse(Rb1.Text);
        }

        private void Rb2_CheckedChanged(object sender, EventArgs e)
        {
            points = Int32.Parse(Rb2.Text);
        }

        private void Rb3_CheckedChanged(object sender, EventArgs e)
        {
            points = Int32.Parse(Rb3.Text);
        }

        private void Rb4_CheckedChanged(object sender, EventArgs e)
        {
            points = Int32.Parse(Rb4.Text);
        }

        private void Rb5_CheckedChanged(object sender, EventArgs e)
        {
            points = Int32.Parse(Rb5.Text);
        }
    }
}
