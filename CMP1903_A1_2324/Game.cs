using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Game
    {
        public Die[] dice;      // Creates an array to hold dice objects
        
        public Game() 
        { 
            dice = new Die[3];          // initalises and creates three dice objects

            // Creates three die objects and will assign them to the dice array
            for (int i = 0; i < 3; i++)
            {
                dice[i] = new Die();
            }
        }

        public int RollAllTheDice()
        {
            int total = 0;
            int[] rolls = new int[3];

            // Rolls each dice to get a value and stores it in the array 
            for (int i = 0; i < 3; i++)
            {
                rolls[i] = dice[i].Roll();
                total += rolls[i];
            }

            //Displays all of the dice rolls and the total sum
            Console.WriteLine("Individual die rolls: " + string.Join(", ", rolls));
            Console.WriteLine("Total of the three dice rolls; " + total);
            return total;
        }

        // Allows access for the dice array from outside of the game class
        public Die[] Dice
        {
            get 
            { 
                return dice; 
            }
        }
    }
}
