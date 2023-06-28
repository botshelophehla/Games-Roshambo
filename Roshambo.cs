using System;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our roshambo game");
            Console.WriteLine("To play: enter 1 for Rock, 2 for Paper, 3 for Scissors.");

            Console.WriteLine();
            bool playAgain;
            do
            {
                //player input
                string inputroshambo;
                bool correct = true;
                do
                {
                    Console.Write("Please enter your roshambo: ");
                    inputroshambo = Console.ReadLine();

                    if (inputroshambo == "1" || inputroshambo == "2" || inputroshambo == "3")
                    {
                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect roshambo. Please try again.");
                        correct = false;
                    }
                } while (!correct);


                Console.WriteLine();

                //computer player
                Random random = new Random();

                //generate random roshambo
                int opponentNum = random.Next(1, 4);

                // 1 = Rock, 2 = Paper, 3 = Scissors

                string opponent = "";
                switch (opponentNum)
                {
                    case 1:
                        opponent = "1";
                        break;
                    case 2:
                        opponent = "2";
                        break;
                    case 3:
                        opponent = "3";
                        break;
                    default:
                        opponent = "Incorrect";
                        break;
                }

                //compare user input and computer choice
                Console.WriteLine("Opponent: " + opponent);
                Console.WriteLine();
                if (inputroshambo == opponent)
                {
                    Console.WriteLine("The game ended in a draw!");
                }
                else if ((inputroshambo == "2" && opponent == "1") ||
                         (inputroshambo == "3" && opponent == "2") ||
                         (inputroshambo == "1" && opponent == "3"))
                {
                    Console.WriteLine("Hurray! You won the game");
                }
                else
                {
                    Console.WriteLine("You lost the game! Better luck next time");
                }

                Console.WriteLine();

                Console.WriteLine("Do you want to play again? (yes/no)");
                Console.WriteLine();
                string playAgainChoice = Console.ReadLine().ToLower();

                playAgain = (playAgainChoice == "yes");

                Console.WriteLine();
            }
            while (playAgain);

            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();
        }
    }
}
