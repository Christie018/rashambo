using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roshambo;

enum Roshambo
{
    Rock,
    Paper,
    Scissors
}

namespace roshambo
{
    abstract class Player
    {
        public string Name { get; set; }
        public Roshambo Choice { get; set; }

        // Abstract method for generating Roshambo value
        public abstract void GenerateRoshambo();
    }
}
