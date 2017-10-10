using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backgammon_Game
{
    public class Board
    {
        //board contains pips
        Pips[] GameBoard;
        //private ctor
        private Board()
        {

        }

        //ctor
        public Board(Person [] users)
        {
            GameBoard = new Pips[26];

            for (int i = 0; i < 26; i++)
            {
                GameBoard[i] = new Pips(i);
            }

            int[,] InitialState = new int[,] { { 6, 5 }, { 8, 3 }, { 13, 5 }, { 24, 2 } };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < InitialState[i, 1]; j++)
                {
                    GameBoard[InitialState[i, 0]].AddPip(users[0]);
                    GameBoard[25-InitialState[i, 0]].AddPip(users[1]);
                }
            }
        }

        public Board Copy()
        {
            Board b = new Board();
            for (int i = 0; i < 26; i++)
            {
                b.GameBoard[i] = GameBoard[i].Copy();
            }
            return b;
        }

        public bool TransferPips(Person p, int src, int dst)
        {
            return GameBoard[src].RemovePip(p) && GameBoard[dst].AddPip(p);
        }

        public Pips[] GetGameBoard 
        {
            get { return GameBoard;  }        
        }

        public bool IsPipTransferValid(Person p, int src, int dst, int[] off)
        {
            int offs = src - dst;

            //wrong return statement
            return GameBoard[src].CanBeRemoved(p) && GameBoard[dst].CanBeAdded(p) && (Math.Sign(offs) == p.GetDirection)
                && (Math.Abs(offs) == off[0] || Math.Abs(offs) == off[1]);
        }
    }
}
