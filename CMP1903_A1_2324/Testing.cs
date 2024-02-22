using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Testing
    {
        public static void Test()
        {
            Game game = new Game();
            int[] rolls = new int[3];    // This is an array to store the rolls that happen

            // This below will roll all the dice and store the rolls
            for (int i = 0; i < 3; i++)
            {
                rolls[i] = game.dice[i].Roll();
            }

            // Testing to ensure that the rolls are between 1 and 6
            foreach (int roll in rolls)
            {
                Debug.Assert(1 <= roll && roll <= 6, "The die roll was out of range: " + roll);
            }

            // Testing that the sum of every roll is less than a certain amount
            int total = rolls.Sum();
            Debug.Assert(3 <= total && total <= 18, "The total value was out of range: " + total);

            Console.WriteLine("All of the tests have successfully passed");
        }
    }
}
