using System;

namespace CoreGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new CGame();
            game.Run(60, 60);

            Console.ReadLine();
        }
    }
}
