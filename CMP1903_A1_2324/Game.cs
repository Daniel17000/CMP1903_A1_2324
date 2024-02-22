using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Game
    {
        public Die[] dice;
        
        public Game() 
        { 
            dice = new Die[3];
            for (int i = 0; i < 3; i++)
            {
                dice[i] = new Die();
            }
        }

        public int RollAllTheDice()
        {
            int total = 0;
            int[] rolls = new int[3];
            for (int i = 0; i < 3; i++)
            {
                rolls[i] = dice[i].Roll();
                total += rolls[i];
            }

            Console.WriteLine("Individual die rolls: " + string.Join(", ", rolls));
            Console.WriteLine("Total of the three dice rolls; " + total);
            return total;
        }

        public Die[] Dice
        {
            get 
            { 
                return dice; 
            }
        }
    }
}
