using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Die
    {

        private static Random random = new Random();    // This is to hold a single instance of Random

        //Private fields to store values
        private int currentValue;
        

        public int Roll()
        {
            currentValue = random.Next(1,7); // This is inclusive, gets a number between 1 and 6
            return currentValue;
        }
    }
}
