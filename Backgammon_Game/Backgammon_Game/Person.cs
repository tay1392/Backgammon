using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backgammon_Game
{
    public class Person
    {
        private Person Opp; //opponent
        private bool AI; //human or AI
        private bool Pen = false; //penalty
        private int Points = 0;
        private int Points_game = 0;
        private int Direc; //direction around board, +/- 1
        private Color color;
        private String PlayerName;

        //person constructor
        public Person(String name, Color col, int dir, bool ai)
        {
            this.PlayerName = name;
            this.color = col;
            this.Direc = dir;
            this.AI = ai;
        }

        //Getters
        public bool IsAI { get { return AI; } }
        
        public static void CreateOpponents(Person p1, Person p2)
        {
            p1.Opp = p2;
            p2.Opp = p1;
        }

        public Person Op { get { return Opp; } }

        public bool Penalize { get { return Pen; } set { Pen = value; } }
        public int Game_Points{ get { return Points_game; } set { Points_game = value; } }
        public int GetPoints { get { return Points; } }
        public void ResetPts(){ Points_game = 0; }
        public String Name { get { return PlayerName;  } }
        public Color PipColor { get { return color;  } }
        public int GetDirection { get { return Direc; } }

        public void AddPoints(int p)
        {
            this.Points += p;
        }

        public void SubtractPoints(int p)
        {
            if(this.Points >= p)
            {
                this.Points -= p;
            }
            
        }

        public override String ToString()
        {
            return PlayerName;
        }
    }
}
