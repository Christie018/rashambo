using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshambo
{
    // RockPlayer subclass
    class RockPlayer : Player
    {
        public override void GenerateRoshambo()
        {
            Choice = Roshambo.Rock; // Always throws Rock
        }
    }

}
