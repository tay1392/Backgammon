using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon_Game
{
    public class Driver
    {
        public Person[] people;
        public Board GameBoard;
        public int CurrIndx = 0;
        public Dice dice;
        public int rnd;
        public MainGameForm GameWindow;
        public int Max;
       // public int[] InitRoll;
        public bool Begun, DoubleDiceRoll;
        public int mvs = 2;
        public int[] first;

        public Person CurrentPerson { get { return people[CurrIndx]; } }
        public Person OtherPerson { get { return people[(CurrIndx + 1 ) %2]; } } //this was wrong
        public int PenIndx { get { return 25 * (1 - CurrIndx); } }
        public int OtherPenIndx { get { return 25 * (CurrIndx); } }

        public Driver(Person[] players, int max)
        {
            this.people = players;
            this.Max = max;
            first = new int[2];
            dice = new Dice();    
        }

        public void Move(int src, int dst)
        {
            int off = Math.Abs(src - dst);

            if(GameBoard.GetGameBoard[dst].GetOwner != CurrentPerson && GameBoard.GetGameBoard[dst].GetOwner != null)
            {
                GameBoard.TransferPips(OtherPerson, dst, OtherPenIndx);
                OtherPerson.AddPoints(dst);
                OtherPerson.Penalize = true;
                GameWindow.UpdateStack(OtherPenIndx);
            }

            GameBoard.TransferPips(CurrentPerson, src, dst);
            GameWindow.UpdateStack(src);
            GameWindow.UpdateStack(dst);

            if (GameBoard.GetGameBoard[PenIndx].PipsCount == 0)
                CurrentPerson.Penalize = false;

            CurrentPerson.SubtractPoints(off);
            GameWindow.UpdatePlayerPoints();

            if(CheckWin(dst))
            {
                CurrentPerson.Game_Points += 1;
                EndGame();
                return;
            }

            if(off == dice[0] + dice[1])
            {
                mvs = 0;
            }
            else
            {
                mvs--;
                if(off == dice.GetResult[0])
                {
                    dice[0] = 0;
                }
                else
                {
                    dice[1] = 0;
                }
                GameWindow.UpdateGameDice();
            }

            if(ArtificialIntelligence.CountPossibleMoves(this) == 0)
            {
                mvs = 0;
            }

            if(mvs == 0)
            {
                NextPerson();
            }
            else
            {
                GameWindow.WaitingForMove();
            }

        }



        public void EndGame()
        {
            rnd++;
            if(Max == rnd)
            {
                MessageBox.Show(CurrentPerson.Name + " Won the game!");
                GameWindow.UpdatePlayerInfo("Game Over");
                GameWindow.DiceDisable();
                GameWindow.DisableSel();
            }
            else
            {
                MessageBox.Show(CurrentPerson.Name + " Scores a point!");
                NewGame(GameWindow);
                GameWindow.UpdateGameBoard();
                GameWindow.DisableSel();
                GameWindow.DiceEnable();
                Begun = false;
            }
        }

        private void NextPerson()
        {
            if (!DoubleDiceRoll)
                CurrIndx = (CurrIndx + 1) % 2;
            mvs = 2;

            dice.ResetDice();
            GameWindow.DisableSel();
            GameWindow.WaitingForDiceRoll();
        }

        public void NewGame(MainGameForm g)
        {
            this.GameWindow = g;
            GameBoard = new Board(people);
            foreach (Person p in people)
            {
                p.ResetPts();
            }

            g.UpdatePlayerPoints();
            g.UpdatePlayerInfo();
            g.UpdateGameDice();
        }

        public void Roll()
        {
            dice.RollDice();
            //add sound fx here
            if(!Begun)
            {
                int di = (new Random().Next()) % 2;
                dice[(di + 1) % 2] = 0;
                GameWindow.UpdateGameDice();

                if(first[0] == 0) //null ref exception here
                {
                    first[0] = dice.GetResult[di];
                    CurrIndx = 1;
                    GameWindow.WaitingForDiceRoll();
                }
                else
                {
                    first[1] = dice.GetResult[di];
                    CurrIndx = (first[0] > first[1] ? 0 : 1);
                    NewGame();
                }
            }
            else
            {
                DoubleDiceRoll = dice.CheckDouble();
                GameWindow.UpdateGameDice();
                GameWindow.UpdatePlayerInfo();
                GameWindow.DiceDisable();

                if(ArtificialIntelligence.CountPossibleMoves(this) == 0)
                {
                    NextPerson();
                }
                else
                {
                    GameWindow.WaitingForMove();
                }
            }
        }

        private void NewGame() //could be causing ambiguity issues
        {
            rnd = 0;
            Begun = true;
            DoubleDiceRoll = false;
            dice[0] = first[CurrIndx];
            dice[1] = 0;
            GameWindow.DiceDisable();
            GameWindow.UpdatePlayerInfo(CurrentPerson.ToString() + " moves first " + dice[0]);
            GameWindow.WaitingForMove();
        }

        private bool CheckWin(int dst)
        {
            int pips = 0;
            int start = CurrIndx * 18 + 1;
            int end = 5 + start;

            if(start <= dst && end >= dst)
            {
                for (int i = start; i < end; i++)
                {
                    if(GameBoard.GetGameBoard[i].GetOwner == CurrentPerson)
                    {
                        pips += GameBoard.GetGameBoard[i].PipsCount;
                    }
                }
            }
            return pips == 15;
        }

    }
}
