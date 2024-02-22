using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Die
    {
        private int currentValue;
        private Random random;

        public Die()
        {
            random = new Random();
        }

        public int Roll()
        {
            currentValue = random.Next(1,7);
            return currentValue;
        }
    }
}
