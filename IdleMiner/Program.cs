using System;
using IdleMiner.Items;

namespace IdleMiner
{
    public class Program
    {
        static GameManager gameManager;
        static void Main(string[] args)
        {
            gameManager = new GameManager();

            StartGame();

            Console.ReadKey();
        }

        static void StartGame()
        {
            Console.WriteLine("Enter Your Player Name");
            string input = Console.ReadLine();
            gameManager.CreatePlayer(input);
            
            Console.Clear();

            Console.WriteLine($"Welcome {gameManager.player.GetName()}");

            gameManager.ConductGame();
        }
    }
}
