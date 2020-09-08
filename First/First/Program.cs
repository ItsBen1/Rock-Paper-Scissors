using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            bool playAgain = true;

            while (playAgain)
            {


                while (scorePlayer < 3 && scoreCPU < 3)
                {


                    Console.Write("ROCK, PAPER, or SCISSORS:");
                    inputPlayer = Console.ReadLine();

                    Random random = new Random();
                    randomInt = random.Next(1, 4);
                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("The CPU chose ROCK.");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("It's a draw!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("You Won!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU won!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("The CPU chose PAPER.");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("It's a draw!\n\n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("You Won!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU won!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "Scissors";
                            Console.WriteLine("The CPU chose SCISSORS.");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("It's a draw!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("You Won!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU won!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry!");
                            break;

                    }
                    Console.WriteLine("/n/nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}",scorePlayer, scoreCPU);

                    if (scorePlayer == 3)
                    {
                        Console.WriteLine("Player Won!");
                        Console.WriteLine("Congratulations!");
                    }
                    else if (scoreCPU == 3)
                    {
                        Console.WriteLine("CPU Won!");
                        Console.WriteLine("Maybe next time!");
                    }
                    else
                    {

                    }

                    Console.WriteLine("Do you want to play again?(Y/N)");
                    string loop = Console.ReadLine();
                    if (loop == "Y")
                    {
                        playAgain = true;
                        Console.Clear();
                    }
                    else if (loop == "N")
                    {
                        playAgain = false;
                        Console.Clear();
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
