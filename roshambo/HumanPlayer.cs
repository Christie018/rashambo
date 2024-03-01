using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace roshambo
{
    // HumanPlayer subclass
    class HumanPlayer : Player
    {
        public HumanPlayer(string name)
        {
            Name = name; // Allow the user to input their name
        }

        public override void GenerateRoshambo()
        {
            Console.WriteLine($"{Name}, please select Rock, Paper, or Scissors:");
            string input = Console.ReadLine().ToLower();

            // Validate user input
            while (input != "rock" && input != "paper" && input != "scissors")
            {
                Console.WriteLine("Invalid selection. Please choose Rock, Paper, or Scissors:");
                input = Console.ReadLine().ToLower();
            }

            // Set the player's choice based on user input
            if (input == "rock")
                Choice = Roshambo.Rock;
            else if (input == "paper")
                Choice = Roshambo.Paper;
            else if (input == "scissors")
                Choice = Roshambo.Scissors;
        }
    }

}