using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Backgammon_Game
{
    public class ArtificialIntelligence
    {
        class Node
        {
            public Board board;
            public Person player;
            public int[] DiceResult;
            public List<Node> Offspring;
            public int v;

            public Node(Board b, int[] res, Person player, int val)
            {
                Offspring = null;
                this.DiceResult = res;
                this.board = b;
                v = val;
            }

            public void CalculateOffspring()
            {
                List<int[]> xfer;
                for (int d1 = 1; d1 <= 6; d1++)
                {
                    for (int d2 = 1; d2 <= 6; d2++)
                    {
                        int[] d = { d1, d2 };

                        xfer = CalculatePossMoves(board, player.Op, d);

                        foreach (int[] move in xfer)
                        {
                            Board b = board.Copy();
                            b.TransferPips(player.Op, move[0], move[1]);
                            Offspring.Add(new Node(b, d, player.Op, 0));
                        }
                    }
                }
            }
        }

        class MaxMin
        {
            public Node RootNode;
            public int Depth;
            public MaxMin()
            {
                RootNode = null;
            }

            public void Calc(Board b, int[] res, Person p, int d)
            {
                if(RootNode == null)
                {
                    Depth = d;
                    RootNode = new Node(b, res, p, 0);
                    Queue<Node> q = new Queue<Node>();
                    Node current = RootNode;

                    while(Depth > 0)
                    {
                        foreach (Node n in current.Offspring)
                        {
                            q.Enqueue(n);
                        }
                        while(q.Count > 0)
                        {
                            current = q.Dequeue();
                            current.CalculateOffspring();

                        }
                        Depth--;
                    }

                }
            }
        }

        public static int[] CalculateBestMove(Board b, int[] res, Person p, int d)
        {
            int[] result;
            MaxMin tree = new MaxMin();
            tree.Calc(b, res, p, d);
            bool Maximum = true;
            int mm;
            Node current = tree.RootNode, NextNode;

            while (d > 0)
            {
                NextNode = current.Offspring[0];
                mm = NextNode.v;

                foreach (Node n in current.Offspring)
                {
                    if ((Maximum && n.v > mm) || (!Maximum && n.v < mm))
                    {
                       NextNode = n;
                        mm = n.v;
                    }
                }

                current = NextNode;
                Maximum = !Maximum;
                d--;
            }

            result = null;
            return result;
        }

        public static int CountPossibleMoves(Driver G)
        {
            Person p = G.CurrentPerson;
            int cnt = CalculatePossMoves(G.GameBoard, p, G.dice.GetResult, p.Penalize, G.PenIndx).Count;
            if(cnt == 0)
            {
                MessageBox.Show(p.ToString() + " has no possible moves :(");
            }

            return cnt;
        }

        public static List<int[]> CalculatePossMoves(Board board, Person p, int [] DiceRollRes, bool pen= false, int penIndx = -1)
        {
            //TODO
            List<int[]> Rez = new List<int[]>();

            if (p.Penalize)
            {
                int i = penIndx;
                for (int j = 1; j < 25; j++)
                {
                    if(board.IsPipTransferValid(p, i, j, DiceRollRes))
                    {
                        Rez.Add(new int[] { i, j });
                    }
                }
            }

            for (int i = 1; i < 25; i++)
            {
                if(board.GetGameBoard[i].GetPermission(p))
                {
                    for (int j = 1; j < 25; j++)
                    {
                        if(board.IsPipTransferValid(p, i, j, DiceRollRes))
                        {
                            Rez.Add(new int[] { i, j });
                        }
                    }
                }
            }

            return Rez;
        }
    }
}
