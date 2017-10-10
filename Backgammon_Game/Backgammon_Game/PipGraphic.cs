using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Backgammon_Game
{
    public class PipGraphic : Panel
    {
        //TODO CLASS IS UNFINISHED  
        private const int Limit = 5;
        private const int Xoff = 10;
        private const int Yoff = 20;

        private Pips Subj;
        private PictureBox[] Sprs;
        private BoardGraphic parent;
        private bool Selected;
        private bool Inverse;
        private bool Penalize;

        //images for pips
        private Image BlackPip = Backgammon_Game.Properties.Resources.BlackPip;
        private Image WhitePip = Backgammon_Game.Properties.Resources.WhitePip;

        private Image SprImage;
        private ToolTip Indx;
        private Label FlowOver_Label;

       //constructor
        public PipGraphic(BoardGraphic parentBoard, Pips SubjPips, bool inv, bool pen=false)
        {
            InitializeComponent();
            SprImage = WhitePip;
            parent = parentBoard;
            Subj = SubjPips;
            Width = SprImage.Width + 2;
            Height = Limit * 50 + 2;
            Sprs = new PictureBox[Limit];
            BackColor = Color.Transparent;
            Selected  = false;
            this.Inverse = inv;
            this.Penalize = pen;

            Indx = new ToolTip();
            Indx.IsBalloon = true;
            Indx.UseFading = false;
            Indx.ShowAlways = true;

            for (int i = 0; i < Limit; i++)
            {
                Sprs[i] = new PictureBox();
                Sprs[i].Width = SprImage.Width;
                Sprs[i].Height = SprImage.Height;
                Sprs[i].Image = SprImage;
                Sprs[i].SendToBack();
                Sprs[i].MouseEnter += new System.EventHandler(this.PipGraphic_MouseEnter);
                Sprs[i].MouseLeave += new System.EventHandler(this.PipGraphic_MouseLeave);
                Sprs[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.PipGraphic_MouseClick);

                Controls.Add(Sprs[i]);
                Sprs[i].Location = new Point(0, i * SprImage.Height);

            }

            FlowOver_Label = new Label();
            FlowOver_Label.Font = new Font("AR JULIAN", 14, FontStyle.Regular);
            if(inv)
                FlowOver_Label.Location = new Point(Location.X + Xoff, Location.Y + Yoff);
            else
                FlowOver_Label.Location = new Point(Location.X + Xoff, Location.Y + Height - Yoff*2);
            FlowOver_Label.Visible = false;
            Controls.Add(FlowOver_Label);
            UpdtView();
            BringToFront();
            
        }

        private void PipGraphic_MouseEnter(Object sender, System.EventArgs e)
        {
            if(!Penalize && parent.Hovered(Subj.Index))
            {
                Indx.Show(Subj.Index.ToString(), parent.Game.GameWindow, Location.X + Width / 2, Location.Y);
                if (Selected)
                    BorderStyle = BorderStyle.Fixed3D; //shows indent
                else
                    BorderStyle = BorderStyle.FixedSingle; //stays normal
            }
        }

        private void PipGraphic_MouseLeave(Object sender, System.EventArgs e)
        {
            Indx.Hide(parent.Game.GameWindow);
            if(!Selected && !Penalize)
            {
                BorderStyle = BorderStyle.None;
            }
        }

        private void PipGraphic_MouseClick(Object sender, System.EventArgs e)
        {
            parent.Selected(Subj.Index);
            Indx.Hide(parent.Game.GameWindow);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PipGraphic_MouseClick);
            this.MouseEnter += new System.EventHandler(this.PipGraphic_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PipGraphic_MouseLeave);
            this.ResumeLayout(false);
        }

        public void SetSel(bool sel)
        {
            this.Selected = sel;
            if (Penalize) return;

            if(Selected)
            {
                BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                BorderStyle = BorderStyle.None;
            }
        }

        public Pips Subject { get { return Subj; } }

        public void UpdtView()
        {
            if(Subj.GetOwner != null)
            {
                SprImage = (Subj.GetOwner.PipColor == Color.White ? WhitePip : BlackPip);
            }

            for (int i = 0; i < Limit; i++)
			{
			    Sprs[i].Image = SprImage;

                if (i < Subj.PipsCount)
                    Sprs[(Inverse ? (Limit - i - 1) : i)].Visible = true;
                else
                    Sprs[(Inverse ? (Limit - i - 1) : i)].Visible = false;

			}

            if(Subj.PipsCount > Limit)
            {
                int over = Subj.PipsCount - Limit;
                FlowOver_Label.Text = "+" + (over + 1);
                Sprs[(Inverse ? 0 : (Limit - 1))].Visible = false;
            }

            FlowOver_Label.Visible = Subj.PipsCount > Limit;

        }
    }
}
