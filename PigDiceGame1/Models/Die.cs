using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame1.Models
{
    internal class Die
    {
        private static Random random = new Random();

        public int Roll()
        {
            return random.Next(1, 7);
        }
    }
}
