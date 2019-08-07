using System;
using System.Collections.Generic;
using System.Text;

namespace RollDice
{
    class Dice
    {
        private int throws { get; set; }
        private int die { get; set; }

        public Dice()
        {
        }

        public int RollDie(int throws, int die)
        {
            int result = 0;
            int score = 0;

            Random rd = new Random();

            for (int i=0; i < throws; i++)
            {
                score = rd.Next(1, die + 1);
                Console.WriteLine(score);
                result += score;
            }
            
            return result;
        }
    }
}
