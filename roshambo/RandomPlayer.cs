using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshambo
{
    class RandomPlayer : Player
    {
        Random random = new Random();

        public override void GenerateRoshambo()
        {
            Choice = (Roshambo)random.Next(0, 3); // Picks and throws a value at random
        }
    }
}
