/* Rashambo Rock Paper Scissors 
 * Mattalynn Darden
 * 2/28/24 */
using roshambo;
Console.WriteLine("Welcome to Rock, Paper, Scissors!");

// Create a HumanPlayer
Console.Write("Enter your name: ");
string playerName = Console.ReadLine();
HumanPlayer humanPlayer = new HumanPlayer(playerName);

// Select opponent
Console.WriteLine("Select your opponent:");
Console.WriteLine("1. Rock Player");
Console.WriteLine("2. Random Player");
Console.Write("Enter your choice (1 or 2): ");
int opponentChoice = int.Parse(Console.ReadLine());

Player opponent;
if (opponentChoice == 1)
    opponent = new RockPlayer();
else
    opponent = new RandomPlayer();

// Game loop
bool playAgain = true;
while (playAgain)
{
    // Generate choices for players
    humanPlayer.GenerateRoshambo();
    opponent.GenerateRoshambo();

    // Display choices and result
    Console.WriteLine($"{humanPlayer.Name} chose {humanPlayer.Choice}");
    Console.WriteLine($"Opponent chose {opponent.Choice}");

    // Determine the winner
    if ((humanPlayer.Choice == Roshambo.Rock && opponent.Choice == Roshambo.Scissors) ||
        (humanPlayer.Choice == Roshambo.Paper && opponent.Choice == Roshambo.Rock) ||
        (humanPlayer.Choice == Roshambo.Scissors && opponent.Choice == Roshambo.Paper))
    {
        Console.WriteLine($"{humanPlayer.Name} wins!");
    }
    else if ((opponent.Choice == Roshambo.Rock && humanPlayer.Choice == Roshambo.Scissors) ||
             (opponent.Choice == Roshambo.Paper && humanPlayer.Choice == Roshambo.Rock) ||
             (opponent.Choice == Roshambo.Scissors && humanPlayer.Choice == Roshambo.Paper))
    {
        Console.WriteLine("Opponent wins!");
    }
    else
    {
        Console.WriteLine("It's a tie!");
    }

    // Ask if the player wants to play again
    Console.Write("Do you want to play again? (yes/no): ");
    string playAgainInput = Console.ReadLine().ToLower();
    playAgain = (playAgainInput == "yes");
}

Console.WriteLine("Thanks for playing Rock, Paper, Scissors!");