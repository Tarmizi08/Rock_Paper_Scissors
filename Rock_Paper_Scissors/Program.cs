using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerScore = 0;

            int enemyScore = 0;

            Console.WriteLine("Welcome to rock paper scissors");

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player Score - " + playerScore + " .Enemy Score: " + enemyScore);
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper or anything else for scissors");

                string playerChoice = Console.ReadLine();
                
                int enemyChoice = random.Next(0, 3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy choose Rocks");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!!");
                            break;
                        case "p":
                            Console.WriteLine("Enemy Lose!!");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy win this round");
                            enemyScore++;
                            break;
                    }
                } else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy choose Paper");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy wins this round");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie");
                            break;
                        default:
                            Console.WriteLine("Player win this round");
                            playerScore++;
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Enemy choose Scissors");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player won this round");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Enemy win this round");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("Ties");
                            break;
                    }
                }
            }

            if (playerScore == 3)
            {
                Console.WriteLine("You win");
            }
            else
            {
                Console.WriteLine("You lose");
            }
        }
    }
}

