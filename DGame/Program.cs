using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new DDGame();
            game.Run(60, 60);

            Console.ReadLine();
        }
    }
}
