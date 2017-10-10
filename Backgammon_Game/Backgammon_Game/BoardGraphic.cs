using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Backgammon_Game
{
    public class BoardGraphic : Panel
    {
        public Board Subj;
        public PipGraphic[] pips;
        private int src, dst;
        private Image Background;
        public Driver Game;
        const int PenX = 325;
        const int PenY = 15;
        const int width = 50;

        public BoardGraphic(Driver d)
        {
            Game = d;
            this.Subj = Game.GameBoard;
            pips = new PipGraphic[26];
            src = -1;
            dst = -1;
            BorderStyle = BorderStyle.FixedSingle;
            //TODO Background = resources....
            Background = Backgammon_Game.Properties.Resources.Back;
            BackgroundImage = Background;

            int xof;
            Width = Background.Width;
            Height = Background.Height;
            Enabled = false;

            for (int i = 0; i < 26; i++)
            {
                pips[i] = new PipGraphic(this, Subj.GetGameBoard[i], (i<13), (i==0 || i == 25));
                Subj.GetGameBoard[i].SetView(pips[i]);
                Controls.Add(pips[i]);

                if(i < 1 || i > 24)
                {
                    pips[i].Location = new Point(PenX, PenY + ((i == 0 ? 0 : 1) * (pips[i].Height + 10)));
                    pips[i].Enabled = false;
                    pips[i].BorderStyle = BorderStyle.Fixed3D;
                    pips[i].BackColor = Color.DarkGray;
                }
                else
                {
                    xof = 0;

                    if (i > 6 && i < 13)
                        xof = -100;

                    if (i > 18)
                        xof = 100;

                    if(i < 13)
                    {
                        pips[i].Location = new Point(xof + Width - ((i) * width), Height - pips[i].Height);
                    }
                    else
                    {
                        pips[i].Location = new Point(xof + (i - 13) * width, 0);
                    }
                }

                src = -1;
                dst = -1;
            }

        }

        public bool Hovered(int i)
        {
            if (src == -1)
            {
                return Subj.GetGameBoard[i].CanBeRemoved(Game.CurrentPerson);
            }
            else 
            {
                return Subj.IsPipTransferValid(Game.CurrentPerson, src, i, Game.dice.GetResult);
            }
        }

        public bool Selected(int i)
        {
            bool res = false;
            if(src == -1)
            {
                if (pips[i].Subject.CanBeRemoved(Game.CurrentPerson))
                {
                    src = i;
                    pips[i].SetSel(true);
                    res = true;
                }
                else
                {
                    res = false;
                }
            }
            else
            {
                pips[src].SetSel(false);

                if(Subj.IsPipTransferValid(Game.people[Game.CurrIndx], src, i, Game.dice.GetResult))
                {
                    dst = i;
                    Game.Move(src, dst);
                    res = true;

                }
                else
                {
                    res = false;
                    Wait4Move();                
                }

                dst = -1;
            }
            return res;
        }

        public void Wait4Move()
        {
            if(Game.CurrentPerson.Penalize)
            {
                src = Game.PenIndx;
            }
            else
            {
                src = -1;
            }
            if(Game.CurrentPerson.IsAI)
            {
                //TODO DEBUG
                //PossMoves isn't returning the correct valu, always zero 
                List<int[]> PossMoves = ArtificialIntelligence.CalculatePossMoves(Game.GameBoard, Game.CurrentPerson, Game.dice.GetResult, Game.CurrentPerson.Penalize, Game.PenIndx);
                int[] m = PossMoves[0]; //Out of range exception here
                Game.Move(m[0], m[1]);
            }
            else
            {
                Enabled = true;
            }

        }

        public void DisableSelc()
        {
            Enabled = false; //duhhhh
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }

        private void UpdateGraphic()
        {
            for (int i = 0; i < 24; i++)
            {
                pips[i].UpdtView();
            }
        }

    }
}
