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
    public partial class MainGameForm : Form
    {
        BoardGraphic graphic = null;
        public Driver Game;

        public MainGameForm()
        {
            InitializeComponent();
        }
        
        public void UpdateStack(int i)
        {
            graphic.pips[i].UpdtView();
        }

        private void MainGameFormLoad(object sender, EventArgs e)
        {

        }

        private void InfoLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiceButton_Click(object sender, EventArgs e)
        {
            Game.Roll();
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            MoveTimer.Stop();
            graphic.Wait4Move();
        }

        private void DiceTimer_Tick(object sender, EventArgs e)
        {
            DiceTimer.Stop();
            Game.Roll();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            if (Game!=null)
            {
                if (Game.Begun)
                {
                    DialogResult dg = MessageBox.Show("Start New Game?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.No)
                        return;
                }
                else
                    return;
            }

            if(graphic != null)
            {
                graphic.Dispose();
            }

            MainMenuForm MMF = new MainMenuForm();
            MMF.ShowDialog();
            Game = MMF.GetNewGame();

            Game.NewGame(this);
            graphic = new BoardGraphic(Game);

            Controls.Add(graphic);
            graphic.Location = new Point(10, 10);

            PointsPanel.Visible = true;
            DiceButton.Visible = true;
            DiceLabel.Visible = true;
            WaitingForDiceRoll();

        }

        public void DiceDisable()
        {
            DiceButton.Enabled = false;
        }

        public void DiceEnable()
        {
            DiceButton.Enabled = true;
        }

        public void ShowWin()
        {
            InfoLabel.Text = Game.CurrentPerson.ToString() + "Game Won!";
            DiceButton.Enabled = false;
            NewGameButton.Enabled = true;
        }

        public void WaitingForMove()
        {
            if(Game.CurrentPerson.IsAI)
            {
                MoveTimer.Start();
            }
            else
            {
                graphic.Wait4Move();
            }
        }

        public void WaitingForDiceRoll()
        {
            InfoLabel.Text = Game.CurrentPerson.ToString() + " - Roll the dice";
            if (Game.CurrentPerson.IsAI)
            {
                DiceButton.Enabled = false;
                DiceTimer.Start();
            }
            else
            {
                DiceButton.Enabled = true;
            }
        }

        public void UpdatePlayerInfo(String info = "")
        {
            if(info == "")
            {
                InfoLabel.Text = Game.CurrentPerson.ToString() + "'s" + " move";
            }
            else
            {
                InfoLabel.Text = info;
            }
        }


        public void DisableSel()
        {
            graphic.DisableSelc();
        }

        public void UpdatePlayerPoints()
        {
            Person1Label.Text = Game.people[0].Name + ":   " + Game.people[0].GetPoints + " / " + Game.people[0].Game_Points;
            Person1Label.Text = Game.people[1].Name + ":   " + Game.people[1].GetPoints + " / " + Game.people[1].Game_Points;
        }

        public void UpdateGameBoard()
        {
            for (int i = 0; i < 26; i++)
            {
                UpdateStack(i);
            }
        }

        public void UpdateGameDice()
        {
            DiceLabel.Text = Game.dice.ToString();
        }
    }
}
