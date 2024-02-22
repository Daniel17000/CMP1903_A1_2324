using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program.Run();
        }

        public static void Run()
        {
            // Creating a game object
            Game game = new Game();
            // Rolling the dice for the turn
            int total = game.RollAllTheDice();
            // Will perform all the testing in place
            Testing.Test();
            Console.ReadLine();

        }
    }
}
