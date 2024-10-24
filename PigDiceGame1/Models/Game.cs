using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame1.Models
{
    internal class Game
    {
        private int totalScore;
        private int turnCount;
        private Die die;

        public Game()
        {
            totalScore = 0;
            turnCount = 0;
            die = new Die();
        }

        public void Play()
        {
            Console.WriteLine("Welcome to Pig Dice Game!");

            while (totalScore < 20)
            {
                turnCount++;
                Console.WriteLine($"TURN {turnCount}:\n");
                PlayTurn();
            }

            Console.WriteLine($"You completed the game in {turnCount} turns. Game Over!");
        }

        private void PlayTurn()
        {
            int turnScore = 0;

            while (true)
            {
                Console.WriteLine("Enter 'r' to roll again or 'h' to hold:");
                string input = Console.ReadLine().Trim().ToLower();

                if (input != "r" && input != "h")
                {
                    Console.WriteLine("Invalid input, please enter 'r' to roll again (or) 'h' to hold.");
                    continue;
                }

                if (input == "r")
                {
                    int roll = die.Roll();
                    Console.WriteLine($"You rolled: {roll}");

                    if (roll == 1)
                    {
                        Console.WriteLine("Turn over, no score.\n");
                        turnScore = 0;
                        break;
                    }
                    else
                    {
                        turnScore += roll;
                        Console.WriteLine($"Your turn score is {turnScore} and your total score is {totalScore}.");
                        Console.WriteLine($"If you hold, you will have {totalScore + turnScore}.");
                    }
                }
                else if (input == "h")
                {
                    totalScore += turnScore;
                    Console.WriteLine($"Your turn score is {turnScore} and total score is {totalScore}.");
                    break;
                }
            }
        }
    }
}

