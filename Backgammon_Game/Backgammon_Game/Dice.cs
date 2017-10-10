using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Backgammon_Game
{
    public class Dice
    {
        private static String DiceString = "⚀⚁⚂⚃⚄⚅";
        private int[] Result;
        private int n;
        
        private int RandomInteger()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 6);
            return randomNumber;
        }

        //ctor
        public Dice()
        {
            Result = new int[2];
            Result[0] = 0;
            Result[1] = 0;
        }

        //simulates the rolling of dice
        public int[] RollDice()
        {
            int [] nums = new int[2];
            for (int i = 0; i < 2; i++)
            {
                nums[i] = RandomInteger();
                while(nums[i] == Result[i])
                {
                    nums[i] = RandomInteger();
                }
            }
            Result = nums;
            return nums;
        }

        //getters and setters
        public int[] GetResult { get { return Result; } }
        
        //overload []
        public int this[int i]
        {
            get { return Result[i]; }
            set { Result[i] = value; }
        }

        //set values back to zero
        public void ResetDice()
        {
            this[0] = 0;
            this[1] = 0;
        }

        public bool CheckDouble()
        {
            return (this[0] == this[1]) && (this[0] != 0);
        }

        //returns the string version of the roll
        public override string ToString()
        {
            if(Result[0] != 0 && Result[1] != 0)
            {
                return DiceString[Result[0] - 1] + " " + DiceString[Result[1] - 1];
            }
            else if (Result[0] == 0 && Result[1] == 0)
            {
                return "";
            }
            else
            {
                int i = (Result[0] != 0 ? 0 : 1);
                return "" + DiceString[Result[i] - 1];
            }
        }
    }
}
